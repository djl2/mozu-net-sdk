using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Clients.Platform;
using Mozu.Api.Clients.Commerce.Catalog.Admin.Products;
using Mozu.Api.Resources.Commerce.Catalog.Admin;
using Mozu.Api.Resources.Commerce.Catalog.Admin.Products;
using Mozu.Api.Resources.Platform;

namespace Mozu.Api.Test
{
    [TestClass]
    public class ProductTest : BaseTest
    {
        [TestMethod]
        public void GetProductsTest()
        {
            var apiContext = new ApiContext {BaseUrl = BaseUrl};

            //var apiContext = new ApiContext();
            apiContext.TenantId = 7804;
            apiContext.SiteId = 9931;

            var products = new ProductResource(apiContext);
            var productCollection = products.GetProducts(null, null, 100, null, null, null, null);
            Thread.Sleep(1000);
            productCollection = products.GetProducts(null, null, 100, null, null, null, null);
            Thread.Sleep(1000);
            productCollection = products.GetProducts(null, null, 100, null, null, null, null);
            Thread.Sleep(48000);
            productCollection = products.GetProducts(null, null, 100, null, null, null, null);
            Thread.Sleep(1000);
            productCollection = products.GetProducts(null, null, 100, null, null, null, null);
        }
    }
}
