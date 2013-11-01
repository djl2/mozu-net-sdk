using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Mozu.Api.Contracts.AdminUser;
using Mozu.Api.Contracts.Core;
using Mozu.Api.Urls.Platform.Adminuser;
using Mozu.Api.Utilities;
using Newtonsoft.Json;

namespace Mozu.Api.Security
{
    public class UserAuthentication
    {
        private static UserAuthentication _userAuth = null;

        protected static object _lockObj = new Object();

        /*/// <summary>
        /// The appId for the application version
        /// </summary>
        private string _appId;

        /// <summary>
        /// The shared secret for the application version
        /// </summary>
        private string _sharedSecret;
        */

        private UserAuthInfo _userAuthInfo;

        /// <summary>
        /// The base URL of the Mozu application authentication service
        /// </summary>
        //private string _baseUrl;

        private ApiContext _apiContext;

        /// <summary>
        /// The application authentication ticket
        /// </summary>
        private TenantAdminUserAuthTicket _tanantAuthTicket = null;

        private RefreshInterval _refreshInterval = null;

        private int? _tenantId;

        /// <summary>
        /// This contructor does application authentication and setups up the necessary timers to keep the app auth ticket valid.
        /// </summary>
        /// <param name="appId">The application version's app id</param>
        /// <param name="sharedSecret">The application version's shared secret</param>
        /// <param name="baseAppAuthUrl">The base URL of the Mozu application authentication service</param>
        protected UserAuthentication(UserAuthInfo userAuthInfo, string baseAppAuthUrl, RefreshInterval refreshInterval = null)
        {

            _apiContext = new ApiContext { BaseUrl = baseAppAuthUrl };
            _userAuthInfo = userAuthInfo;
            _refreshInterval = refreshInterval;
        }


        public static UserAuthentication Initialize(UserAuthInfo userAuthInfo, string baseAppAuthUrl, RefreshInterval refreshInterval = null)
        {
            if (_userAuth == null)
            {
                lock (_lockObj)
                {
                    try
                    {
                        _userAuth = new UserAuthentication(userAuthInfo, baseAppAuthUrl, refreshInterval);
                        _userAuth.AuthenticateUser();
                    }
                    catch (ApiException exc)
                    {
                        _userAuth = null;
                        throw exc;
                    }
                }
            }

            return _userAuth;
        }


        public void AuthenticateUser()
        {
            AuthenticateUser(null);
        }

        /// <summary>
        /// Do application authentication
        /// </summary>
        public void AuthenticateUser(int? tenantId)
        {
            _tenantId = tenantId;
            var resourceUrl = TenantAdminUserAuthTicketUrl.CreateUserAuthTicketUrl(tenantId); //AuthTicketUrl.AuthenticateAppUrl();

            var client = new HttpClient { BaseAddress = new Uri(_apiContext.BaseUrl) };

            var stringContent = JsonConvert.SerializeObject(_userAuthInfo);

            Authentication.AddAuthHeader(client);

            var response = client.PostAsync(resourceUrl, new StringContent(stringContent, Encoding.UTF8, "application/json")).Result;
            ResponseHelper.EnsureSuccess(response);

            _tanantAuthTicket = response.Content.ReadAsAsync<TenantAdminUserAuthTicket>().Result;

            SetRefreshIntervals(true);
        }


        public void RefreshUserAuthTicket()
        {
            RefreshUserAuthTicket(null);
        }


        /// <summary>
        /// Refresh the application auth ticket using the refresh token
        /// </summary>
        public void RefreshUserAuthTicket(int? tenantId)
        {
            _tenantId = tenantId;
            var resourceUrl = TenantAdminUserAuthTicketUrl.RefreshAuthTicketUrl(tenantId);

            var client = new HttpClient { BaseAddress = new Uri(_apiContext.BaseUrl) };
            Authentication.AddAuthHeader(client);


            //var authTicketRequest = new AuthTicketRequest { RefreshToken = _appAuthTicket.RefreshToken };
            var stringContent = JsonConvert.SerializeObject(_tanantAuthTicket);

            var response = client.PutAsync(resourceUrl, new StringContent(stringContent, Encoding.UTF8, "application/json")).Result;
            ResponseHelper.EnsureSuccess(response);
            //response.EnsureSuccessStatusCode();

            _tanantAuthTicket = response.Content.ReadAsAsync<TenantAdminUserAuthTicket>().Result;

            SetRefreshIntervals(false);

        }

        private void SetRefreshIntervals(bool updateRefreshTokenInterval)
        {
            if (_refreshInterval == null)
            {
                _refreshInterval = new RefreshInterval
                {
                    AccessTokenExpirationInterval = (long)( _tanantAuthTicket.AccessTokenExpiration-DateTime.Now).TotalSeconds-180,
                    RefreshTokenExpirationInterval = (long)(_tanantAuthTicket.RefreshTokenExpiration-DateTime.Now).TotalSeconds - 180
                };
            }

            _refreshInterval.AccessTokenExpiration =
                DateTime.Now.AddSeconds(_refreshInterval.AccessTokenExpirationInterval);

            if (updateRefreshTokenInterval)
                _refreshInterval.RefreshTokenExpiration =
                    DateTime.Now.AddSeconds(_refreshInterval.RefreshTokenExpirationInterval);
        }

        /// <summary>
        /// Ensure that the auth ticket is valid.  If not, then make it so.  Will be used when not using timers to keep the auth ticket alive (i.e. "on demand" mode).
        /// </summary>
        public void EnsureAuthTicket()
        {
            lock (_lockObj)
            {
                if (_tanantAuthTicket == null || DateTime.UtcNow >= _refreshInterval.RefreshTokenExpiration)
                    AuthenticateUser(_tenantId);
                else if (DateTime.UtcNow >= _refreshInterval.AccessTokenExpiration)
                    RefreshUserAuthTicket(_tenantId);
            }
        }



        /// <summary>
        /// This method adds the necessary user claims header to a http client to allow authorized calls to Mozu services
        /// </summary>
        /// <param name="client">The http client for which to add the header</param>
        public static void AddUserAuthHeader(HttpClient client)
        {
            if (_userAuth == null)
                throw new ApplicationException("User Auth is Not Initialized");

            _userAuth.EnsureAuthTicket();
            client.DefaultRequestHeaders.Add(Headers.X_VOL_USER_CLAIMS, _userAuth.UserAuthTicket.AccessToken);
        }

        public static void AddUserAuthHeader(HttpRequestMessage requestMsg)
        {
            if (_userAuth == null)
                throw new ApplicationException("User Auth is Not Initialized");

            _userAuth.EnsureAuthTicket();
            requestMsg.Headers.Add(Headers.X_VOL_USER_CLAIMS, _userAuth.UserAuthTicket.AccessToken);
        }

        /// <summary>
        /// The application auth ticket
        /// </summary>
        public TenantAdminUserAuthTicket UserAuthTicket
        {
            get { return _tanantAuthTicket; }
        }

        public static UserAuthentication Instance
        {
            get { return _userAuth; }
        }
    }
}
