
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Platform.Adminuser
{
	public partial class TenantAdminUserAuthTicketUrl : MozuUrl
	{

				/// <summary>
        /// Get Resource Url for CreateUserAuthTicket
        /// </summary>
        /// <param name="tenantId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateUserAuthTicketUrl(int? tenantId)
		{
			var url = "/api/platform/adminuser/authtickets/tenants?tenantId={tenantId}";
			FormatUrl( ref url, "tenantId", tenantId);
			return new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD) ;
		}

				/// <summary>
        /// Get Resource Url for RefreshAuthTicket
        /// </summary>
        /// <param name="tenantId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RefreshAuthTicketUrl(int? tenantId)
		{
			var url = "/api/platform/adminuser/authtickets/tenants?tenantId={tenantId}";
			FormatUrl( ref url, "tenantId", tenantId);
			return new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD) ;
		}

				/// <summary>
        /// Get Resource Url for DeleteUserAuthTicket
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteUserAuthTicketUrl(string refreshToken)
		{
			var url = "/api/platform/adminuser/authtickets/?refreshToken={refreshToken}";
			FormatUrl( ref url, "refreshToken", refreshToken);
			return new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD) ;
		}

		
	}
}

