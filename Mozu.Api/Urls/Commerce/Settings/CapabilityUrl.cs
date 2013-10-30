
using System;


namespace Mozu.Api.Urls.Commerce.Settings
{
	public partial class CapabilityUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetCapabilities
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetCapabilitiesUrl(string filter)
		{
			var url = "/api/commerce/settings/capabilities/?filter={filter}";
			FormatUrl( ref url, "filter", filter);
			return url;
		}

								
	}
}

