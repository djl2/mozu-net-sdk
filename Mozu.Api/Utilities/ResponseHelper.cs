using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mozu.Api.Utilities
{
    public class ResponseHelper
    {
        public static void EnsureSuccess(HttpResponseMessage response)
        {
            EnsureSuccess(response,null);
        }

        public static void EnsureSuccess(HttpResponseMessage response, IApiContext apiContext)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var exception = JsonConvert.DeserializeObject<ApiException>(content);
                exception.HttpStatusCode = response.StatusCode;
                exception.CorrelationId = HttpHelper.GetHeaderValue(Headers.X_VOL_CORRELATION, response.Headers);
                exception.ApiContext = apiContext;
                throw exception;
            }
        }
    }
}
