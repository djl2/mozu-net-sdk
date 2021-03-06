
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

namespace Mozu.Api.Urls.Platform.Adminuser
{
	public partial class AdminUserUrl 
	{

		/// <summary>
        /// Get Resource Url for GetUser
        /// </summary>
        /// <param name="userId">Unique identifier of the administrator account to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetUserUrl(string userId)
		{
			var url = "/api/platform/adminuser/accounts/{userId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetTenantScopesForUser
        /// </summary>
        /// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTenantScopesForUserUrl(string userId)
		{
			var url = "/api/platform/adminuser/accounts/{userId}/tenants";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

								
	}
}

