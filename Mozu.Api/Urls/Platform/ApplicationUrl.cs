
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Platform
{
	public partial class ApplicationUrl 
	{

		/// <summary>
        /// Get Resource Url for GetApplication
        /// </summary>
        /// <param name="appId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetApplicationUrl(string appId)
		{
			var url = "/api/platform/applications/{appId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "appId", appId);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateApplication
        /// </summary>
        /// <param name="appId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateApplicationUrl(string appId)
		{
			var url = "/api/platform/applications/{appId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "appId", appId);
			return mozuUrl;
		}

				
	}
}

