using System;
using System.Collections.Generic;
using System.Linq;
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
            if (!response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var exception = JsonConvert.DeserializeObject<ApiException>(content);
                exception.HttpStatusCode = response.StatusCode;
                throw exception;
                //throw new ApplicationException(Exception.ExceptionDetail.Message, new Exception(Exception.ExceptionDetail.StackTrace));
            }
        }
    }
}
