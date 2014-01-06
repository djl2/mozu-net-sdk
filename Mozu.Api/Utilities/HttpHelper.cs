using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Mozu.Api.Utilities
{
    internal class HttpHelper
    {
        public static string UrlScheme;

        public static string GetUrl(string url)
        {
            return String.Format("{0}://{1}", UrlScheme, url);
        }

        public static string GetHeaderValue(string header, HttpResponseHeaders headers)
        {
            IEnumerable<string> value = (headers.Contains(header) ? headers.GetValues(header) : null);
            return GetStringValue(value);
        }

        public static string GetHeaderValue(string header, HttpRequestHeaders headers)
        {
            IEnumerable<string> value = (headers.Contains(header) ? headers.GetValues(header) : null);
            return GetStringValue(value);
        }


        public static int? ParseFirstValue(string header, HttpResponseHeaders headers)
        {
            IEnumerable<string> value = (headers.Contains(header) ? headers.GetValues(header) : null);
            return GetIntValue(value);
        }

        public static int? ParseFirstValue(string header, HttpRequestHeaders headers)
        {
            IEnumerable<string> value = (headers.Contains(header) ? headers.GetValues(header) : null);
            return GetIntValue(value);
        }

        private static string GetStringValue(IEnumerable<string> value)
        {
            var retVal = String.Empty;
            if (value != null && !Equals(value, Enumerable.Empty<string>()))
            {
                var str = value.FirstOrDefault();
                return str ?? String.Empty;
            }
            return retVal;
        }

        private static int? GetIntValue(IEnumerable<string> value)
        {
            if (value != null)
            {
                var firstDataItem = value.FirstOrDefault();
                if (firstDataItem != null)
                {
                    int intVal;
                    if (int.TryParse(firstDataItem, out intVal))
                    {
                        if (intVal == 0)
                            return null;
                        return intVal;
                    }

                }
            }

            return null;
        }
    }
}
