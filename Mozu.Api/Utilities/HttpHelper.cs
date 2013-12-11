using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
