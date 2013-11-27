
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Settings
{
	public partial class ApplicationUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for ThirdPartyGetApplication
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ThirdPartyGetApplicationUrl()
		{
			var url = "/api/commerce/settings/applications/";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

						/// <summary>
        /// Get Resource Url for ThirdPartyUpdateApplication
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ThirdPartyUpdateApplicationUrl()
		{
			var url = "/api/commerce/settings/applications/";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				
	}
}

