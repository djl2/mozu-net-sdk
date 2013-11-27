using System;
using System.Net.Http;
using System.Text;
using Mozu.Api.Contracts.AppDev;
using Mozu.Api.Resources.Platform.Applications;
using Mozu.Api.Urls.Platform.Applications;
using Mozu.Api.Utilities;
using Newtonsoft.Json;
using AuthTicket = Mozu.Api.Contracts.AppDev.AuthTicket;

namespace Mozu.Api.Security
{
    /// <summary>
    /// This class handles Mozu application authentication.
    /// </summary>
    public sealed class AppAuthenticator
    {

        private static AppAuthenticator _auth = null;

        private static object _lockObj = new Object();

        private AppAuthInfo _appAuthInfo;

        private RefreshInterval _refreshInterval = null;

		/// <summary>
		/// The application auth ticket
		/// </summary>
        public AuthTicket AppAuthTicket { get; protected set; }

		/// <summary>
		/// The baseUrl for App Auth.  Once an app auths with this base url, all subsequent MOZU API calls will go to this base url.
		/// </summary>
        public string BaseUrl { get; private set; }

		public static AppAuthenticator Instance
		{
			get { return _auth; }
		}

        public static bool UseSSL { get; protected set; }

        internal AppAuthInfo AppAuthInfo
        {
            get { return _appAuthInfo; }
        }

        public static AppAuthenticator Initialize(AppAuthInfo appAuthInfo, string baseAppAuthUrl, RefreshInterval refreshInterval = null)
        {
            if (_auth == null)
            {
                lock (_lockObj)
                {
                    try
                    {
                        var uri = new Uri(baseAppAuthUrl);
                        UseSSL = (uri.Scheme.ToLower() == "https" ? true : false);
                        _auth = new AppAuthenticator(appAuthInfo, baseAppAuthUrl, refreshInterval);
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

        public static void DeleteAuth()
        {
            if (_auth != null)
            {
                var resourceUrl = AuthTicketUrl.DeleteAppAuthTicketUrl(_auth.AppAuthTicket.RefreshToken);
                var client = new HttpClient { BaseAddress = new Uri(_auth.BaseUrl) };
                var response = client.DeleteAsync(resourceUrl.Url).Result;
                ResponseHelper.EnsureSuccess(response);
            }
        }

        /// <summary>
        /// Do application authentication
        /// </summary>
        public void AuthenticateApp()
        {
            var resourceUrl = AuthTicketUrl.AuthenticateAppUrl();
            var client = new HttpClient { BaseAddress = new Uri(BaseUrl) };
            var stringContent = JsonConvert.SerializeObject(_appAuthInfo);
            var response = client.PostAsync(resourceUrl.Url, new StringContent(stringContent, Encoding.UTF8, "application/json")).Result;
           // response.EnsureSuccessStatusCode();
            ResponseHelper.EnsureSuccess(response);

            AppAuthTicket = response.Content.ReadAsAsync<AuthTicket>().Result;

            SetRefreshIntervals(true);

           
        }
        
        /// <summary>
        /// Refresh the application auth ticket using the refresh token
        /// </summary>
        public void RefreshAppAuthTicket()
        {

            var resourceUrl = AuthTicketUrl.RefreshAppAuthTicketUrl();
			var client = new HttpClient { BaseAddress = new Uri(BaseUrl) };
            var authTicketRequest = new AuthTicketRequest { RefreshToken = AppAuthTicket.RefreshToken };
            var stringContent = JsonConvert.SerializeObject(authTicketRequest);

            var response = client.PutAsync(resourceUrl.Url, new StringContent(stringContent, Encoding.UTF8, "application/json")).Result;
            //response.EnsureSuccessStatusCode();
            ResponseHelper.EnsureSuccess(response);

            AppAuthTicket = response.Content.ReadAsAsync<AuthTicket>().Result;

            SetRefreshIntervals(false);

        }
        
        /// <summary>
        /// This contructor does application authentication and setups up the necessary timers to keep the app auth ticket valid.
        /// </summary>
        /// <param name="appId">The application version's app id</param>
        /// <param name="sharedSecret">The application version's shared secret</param>
        /// <param name="baseAppAuthUrl">The base URL of the Mozu application authentication service</param>
        private AppAuthenticator(AppAuthInfo appAuthInfo, string baseAppAuthUrl, RefreshInterval refreshInterval = null)
        {
            BaseUrl = baseAppAuthUrl;
            _appAuthInfo = appAuthInfo;
            /*_appId = appId;
            _sharedSecret = sharedSecret;*/
            _refreshInterval = refreshInterval;
        }
        
        private void SetRefreshIntervals(bool updateRefreshTokenInterval)
        {
            if (_refreshInterval == null)
            {
                _refreshInterval =
                    new RefreshInterval((long) (AppAuthTicket.AccessTokenExpiration - DateTime.Now).TotalSeconds - 180,
                                        (long)(AppAuthTicket.RefreshTokenExpiration - DateTime.Now).TotalSeconds - 180);
            }

            _refreshInterval.UpdateExpirationDates(updateRefreshTokenInterval);
        }

        /// <summary>
        /// Ensure that the auth ticket is valid.  If not, then make it so.  Will be used when not using timers to keep the auth ticket alive (i.e. "on demand" mode).
        /// </summary>
        public void EnsureAuthTicket()
        {
            lock (_lockObj)
            {
                if (AppAuthTicket == null || DateTime.UtcNow >= _refreshInterval.RefreshTokenExpiration)
                    AuthenticateApp();
                else if (DateTime.UtcNow >= _refreshInterval.AccessTokenExpiration)
                    RefreshAppAuthTicket();
            }
        }
        
        /// <summary>
        /// This method adds the necessary app claims header to a http client to allow authorized calls to Mozu services
        /// </summary>
        /// <param name="client">The http client for which to add the header</param>
        public static void AddHeader(HttpClient client)
        {
            if (_auth == null)
                throw new ApplicationException("AppAuthTicketKeepAlive Not Initialized");

            _auth.EnsureAuthTicket();
            client.DefaultRequestHeaders.Add(Headers.X_VOL_APP_CLAIMS, _auth.AppAuthTicket.AccessToken);
        }

        public static void AddHeader(HttpRequestMessage requestMsg)
        {
            if (_auth == null)
                throw new ApplicationException("AppAuthTicketKeepAlive Not Initialized");

            _auth.EnsureAuthTicket();
            requestMsg.Headers.Add(Headers.X_VOL_APP_CLAIMS, _auth.AppAuthTicket.AccessToken);
        }

    }
}
