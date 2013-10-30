using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.Tenant;
using Mozu.Api.Resources.Content.Documentlists;
using Mozu.Api.Resources.Platform;
using Mozu.Api.Security;

namespace Mozu.Api.Test
{
    [TestClass]
    public class TenantTest : BaseTest
    {
       

        [TestMethod]
        public void SettingsTest()
        {
            var apiContext = new ApiContext();
            apiContext.BaseUrl = BaseUrl;
            var tenants = new TenantResource(apiContext);

            var tenant = tenants.GetTenant(1559);
        }

        [TestMethod]
        public void TenantDataTest()
        {
            var documentResource =
                    new DocumentResource(new ApiContext
                    {
                        TenantId = 7656,
                        TenantUrl = "http://t7656.mozu-ci.volusion.com",
                        SiteGroupId = 1,
                        AppAuthTicket = "9I+kRupVJJ+AqMLBw4cdMHeDeipJCAe+uCbzUL3FSSjQbcvx6FQmQk211m9i5sS5pWndovUBFyzaSreabONrooWZUZfYrUbDCzPtgqwP+EJG9YtU797Sik7KcS2LxgdozOWPzwFH4FnaHwKfK0/L8/OzHuU0vxxcTm3UCIyP+GUmQZjH8mcyC5P2okFUJRK2g4B7QyPfz3NSW/dRWmm5Ug=="
                    });

            documentResource.GetDocuments("files");
        }
    }
}
