using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Mozu.Api;
using System.Net.Http;

namespace Mozu.Api.Test.Helpers
{
    public static class ServiceClientMessageFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiContext"></param>
        /// <returns></returns>
        public static ServiceClientMessageHandler GetServiceClientMessageFactory(IApiContext apiContext)
        {

            var msgHandler = new ServiceClientMessageHandler(apiContext);

            return msgHandler;

        }

        public static ServiceClientMessageHandler GetTestClientMessage()
        {
            var apiContext = new ApiContext();
            var msgHandler = new ServiceClientMessageHandler(apiContext);
            return msgHandler;
        }

        public static ServiceClientMessageHandler GetTestClientMessage(int tenantId, 
                                                                       int siteId)
        {
            var apiContext = new ApiContext(tenantId: tenantId, siteId: siteId);
            var msgHandler = new ServiceClientMessageHandler(apiContext);
            return msgHandler;
        }

        public static ServiceClientMessageHandler GetTestClientMessage(int tenantId = 0, int? masterCatalogId = null, int? catalogId = null,
            int? siteId = null)
        {
            var apiContext = new ApiContext(tenantId: tenantId,siteId: siteId,masterCatalogId: masterCatalogId, catalogId: catalogId);
            var msgHandler = new ServiceClientMessageHandler(apiContext);
            return msgHandler;
        }

        public static ServiceClientMessageHandler GetTestClientMessage(HttpRequestHeaders requestHeaders)
        {
            var apiContext = new ApiContext(requestHeaders);
            var msgHandler = new ServiceClientMessageHandler(apiContext);
            return msgHandler;
        }

        public static ServiceClientMessageHandler GetTestShopperMessage(int tenantId = 0,
                                                               int? siteId = null)
        {
            var apiContext = new ApiContext(tenantId: tenantId, siteId: siteId);
            var msgHandler = new ServiceClientMessageHandler(apiContext);
            return msgHandler;
        }
        public static ServiceClientMessageHandler GetTestShopperMessage(int tenantId,
                                                        int? masterCatalogId, 
                                                        int? catalogId, int? siteId = null)
        {
            var apiContext = new ApiContext(tenantId: tenantId, siteId: siteId, masterCatalogId: masterCatalogId, catalogId: catalogId);
            var msgHandler = new ServiceClientMessageHandler(apiContext);
            return msgHandler;
        }
    }

}