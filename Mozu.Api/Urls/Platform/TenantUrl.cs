
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Platform
{
	public partial class TenantUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetTenant
        /// </summary>
        /// <param name="tenantId">Unique identifier of the Mozu tenant.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetTenantUrl(int tenantId)
		{
			var url = "/api/platform/tenants/{tenantId}";
			FormatUrl( ref url, "tenantId", tenantId);
			return url;
		}

								
	}
}

