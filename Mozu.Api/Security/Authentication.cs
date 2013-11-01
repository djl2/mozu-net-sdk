using System;
using System.Net.Http;
using System.Text;
using Mozu.Api.Contracts.AppDev;
using Mozu.Api.Resources.Platform.Applications;
using Mozu.Api.Urls.Platform.Applications;
using Newtonsoft.Json;
using AuthTicket = Mozu.Api.Contracts.AppDev.AuthTicket;
using UserAuthTicket = Mozu.Api.Contracts.Core.UserAuthTicket;

namespace Mozu.Api.Security
{
    /// <summary>
    /// This class handles Mozu application authentication.
    /// </summary>
    public sealed class Authentication
    {

        private static Authentication _auth = null;

        protected static object _lockObj = new Object();

        private AppAuthInfo _appAuthInfo;

        /// <summary>
        /// The base URL of the Mozu application authentication service
        /// </summary>
        //private string _baseUrl;

        private ApiContext _apiContext;

        /// <summary>
        /// The application authentication ticket
        /// </summary>
        private AuthTicket _appAuthTicket = null;

        private RefreshInterval _refreshInterval = null;

        /// <summary>
        /// This contructor does application authentication and setups up the necessary timers to keep the app auth ticket valid.
        /// </summary>
        /// <param name="appId">The application version's app id</param>
        /// <param name="sharedSecret">The application version's shared secret</param>
        /// <param name="baseAppAuthUrl">The base URL of the Mozu application authentication service</param>
        protected Authentication(AppAuthInfo appAuthInfo, string baseAppAuthUrl, RefreshInterval refreshInterval = null)
        {

            _apiContext = new ApiContext { BaseUrl = baseAppAuthUrl };
            _appAuthInfo = appAuthInfo;
            /*_appId = appId;
            _sharedSecret = sharedSecret;*/
            _refreshInterval = refreshInterval;
        }


        public static Authentication Initialize(AppAuthInfo appAuthInfo, string baseAppAuthUrl, RefreshInterval refreshInterval = null)
        {
            if (_auth == null)
            {
                lock (_lockObj)
                {
                    try
                    {
                        _auth = new Authentication(appAuthInfo, baseAppAuthUrl, refreshInterval);
                        _auth.AuthenticateApp();
                    }
                    catch (ApiException exc)
                    {
                        _auth = null;
                        throw exc;
                    }


                }
            }

            return _auth;
        }

        /// <summary>
        /// Do application authentication
        /// </summary>
        public void AuthenticateApp()
        {
            var resourceUrl = AuthTicketUrl.AuthenticateAppUrl();
            var client = new HttpClient {BaseAddress = new Uri(_apiContext.BaseUrl)};
            var stringContent = JsonConvert.SerializeObject(_appAuthInfo);
            var response =
                client.PostAsync(resourceUrl, new StringContent(stringContent, Encoding.UTF8, "application/json"))
                        .Result;

            MozuClient.EnsureSuccess(response);

            _appAuthTicket = response.Content.ReadAsAsync<AuthTicket>().Result;

            SetRefreshIntervals(true);
        }


       /* private void EnsureSuccess(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var exception = JsonConvert.DeserializeObject<ApiException>(content);
                exception.HttpStatusCode = response.StatusCode;
                throw exception;
                //throw new ApplicationException(Exception.ExceptionDetail.Message, new Exception(Exception.ExceptionDetail.StackTrace));
            }
        }*/

        /// <summary>
        /// Refresh the application auth ticket using the refresh token
        /// </summary>
        public void RefreshAppAuthTicket()
        {
            var resourceUrl = AuthTicketUrl.RefreshAppAuthTicketUrl();
            var client = new HttpClient {BaseAddress = new Uri(_apiContext.BaseUrl)};
            var authTicketRequest = new AuthTicketRequest {RefreshToken = _appAuthTicket.RefreshToken};
            var stringContent = JsonConvert.SerializeObject(authTicketRequest);

            var response =
                client.PutAsync(resourceUrl, new StringContent(stringContent, Encoding.UTF8, "application/json"))
                        .Result;
            MozuClient.EnsureSuccess(response);

            _appAuthTicket = response.Content.ReadAsAsync<AuthTicket>().Result;

            SetRefreshIntervals(false);
 
        }

        private void SetRefreshIntervals(bool updateRefreshTokenInterval)
        {
            if (_refreshInterval == null)
            {
                _refreshInterval = new RefreshInterval
                {
                    AccessTokenExpirationInterval = (long)( _appAuthTicket.AccessTokenExpiration-DateTime.Now).TotalSeconds-180,
                    RefreshTokenExpirationInterval = (long)(_appAuthTicket.RefreshTokenExpiration-DateTime.Now).TotalSeconds - 180
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
                if (_appAuthTicket == null || DateTime.UtcNow >= _refreshInterval.RefreshTokenExpiration)
                    AuthenticateApp();
                else if (DateTime.UtcNow >= _refreshInterval.AccessTokenExpiration)
                    RefreshAppAuthTicket();
            }
        }



        /// <summary>
        /// This method adds the necessary app claims header to a http client to allow authorized calls to Mozu services
        /// </summary>
        /// <param name="client">The http client for which to add the header</param>
        public static void AddAuthHeader(HttpClient client)
        {
            if (_auth == null)
                throw new ApplicationException("AppAuthTicketKeepAlive Not Initialized");

            _auth.EnsureAuthTicket();
            client.DefaultRequestHeaders.Add(Headers.X_VOL_APP_CLAIMS, _auth.AppAuthTicket.AccessToken);
        }

        public static void AddAuthHeader(HttpRequestMessage requestMsg)
        {
            if (_auth == null)
                throw new ApplicationException("AppAuthTicketKeepAlive Not Initialized");

            _auth.EnsureAuthTicket();
            requestMsg.Headers.Add(Headers.X_VOL_APP_CLAIMS, _auth.AppAuthTicket.AccessToken);
        }

        /// <summary>
        /// The application auth ticket
        /// </summary>
        public AuthTicket AppAuthTicket
        {
            get { return _appAuthTicket; }
        }

        public Authentication Instance
        {
            get { return _auth; }
        }
    }
}
