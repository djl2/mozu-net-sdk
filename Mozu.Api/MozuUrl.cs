using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mozu.Api
{
	public class MozuUrl
	{
		public enum UrlLocation
		{
			HOME_POD,
			TENANT_POD
		}

		public string Url { get; set; }
		public UrlLocation Location { get; set; }
		
		public MozuUrl()
		{

		}

		public MozuUrl(string url, UrlLocation location)
		{
			Url = url;
			Location = location;
		}

		public static void FormatUrl(ref string url, string paramName, object value)
		{
			url = url.Replace("{" + paramName + "}", value == null ? "" : value.ToString());
			url = url.Replace("{*" + paramName + "}", value == null ? "" : value.ToString());
			var removeString = "&" + paramName + "=";
			if (value == null && url.Contains(removeString)) url = url.Replace(removeString, "");

			removeString = paramName + "=";
			if (value == null && url.Contains(removeString)) url = url.Replace(removeString, "");

			removeString = "/?";
			if (url.EndsWith(removeString)) url = url.Replace(removeString, "");
			if (url.EndsWith(removeString + "&")) url = url.Replace(removeString + "&", "");
			if (url.EndsWith("&")) url = url.Substring(0, url.Length - 1);

			if (url.Contains("/?&")) url = url.Replace("/?&", "/?");

            if (url.EndsWith("?")) url = url.Replace("?", "");
		}
	}
}
