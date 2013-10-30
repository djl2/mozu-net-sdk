using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.Core;
using Mozu.Api.Security;

namespace Mozu.Api.Test
{
    [TestClass]
    public class UserAuthTest : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var userAuthInfo = new UserAuthInfo{EmailAddress = "integrations@volusion.com", Password = "Volusion12345"};

            var userAuth = UserAuthentication.Initialize(userAuthInfo, BaseUrl);

            Assert.IsNotNull(UserAuthentication.Instance);
            Assert.IsNotNull(userAuth.UserAuthTicket.AccessToken);
        }
    }
}
