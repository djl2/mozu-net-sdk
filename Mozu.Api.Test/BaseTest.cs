using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.AppDev;
using Mozu.Api.Security;

namespace Mozu.Api.Test
{
    [TestClass]
    public class BaseTest
    {
        private string _applicationId = "e4c8268a5da746d6a50ba25400ed5f2a";
        private string _sharedSecret = "1e46ddeb47dd4a75b729a25400ed5f2a";
        private string _url = "http://mozu-si.com";

        [TestInitialize]
        public void Initialize()
        {
           // var auth = new Authentication(_applicationId, _sharedSecret, _url);
            var refreshInterval = new RefreshInterval { AccessTokenExpirationInterval = 5000, RefreshTokenExpirationInterval = 60000};
            AppAuthInfo appAuthInfo = new AppAuthInfo {ApplicationId = _applicationId, SharedSecret = _sharedSecret};
            Authentication.Initialize(appAuthInfo, _url, refreshInterval);
        }

        public string BaseUrl
        {
            get { return _url; }
        }
    }
}
