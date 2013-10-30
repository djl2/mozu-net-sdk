using System;

namespace Mozu.Api.Urls
{
	public class BaseUrl
	{
		public static void FormatUrl(ref string url, string paramName, object value)
        {
            url = url.Replace("{"+paramName+"}", value == null ? "" : value.ToString());
			url = url.Replace("{*" + paramName + "}", value == null ? "" : value.ToString());
            var removeString = "&" + paramName + "=";
            if (value == null && url.Contains(removeString)) url = url.Replace(removeString,"");

            removeString = paramName + "=";
            if (value == null && url.Contains(removeString)) url = url.Replace(removeString, "");

            removeString = "/?";
            if (url.EndsWith(removeString)) url = url.Replace(removeString, "");
            if (url.EndsWith(removeString + "&")) url = url.Replace(removeString+"&", "");
			if (url.EndsWith("&")) url = url.Substring(0, url.Length - 1);

		    if (url.Contains("/?&")) url = url.Replace("/?&", "/?");
        }
	}
}