
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Platform.Developer
{
	public partial class DeveloperAdminUserAuthTicketUrl : MozuUrl
	{

				/// <summary>
        /// Get Resource Url for CreateDeveloperUserAuthTicket
        /// </summary>
        /// <param name="developerAccountId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateDeveloperUserAuthTicketUrl(int? developerAccountId)
		{
			var url = "/api/platform/developer/authtickets/?developerAccountId={developerAccountId}";
			FormatUrl( ref url, "developerAccountId", developerAccountId);
			return new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD) ;
		}

				/// <summary>
        /// Get Resource Url for RefreshDeveloperAuthTicket
        /// </summary>
        /// <param name="developerAccountId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RefreshDeveloperAuthTicketUrl(int? developerAccountId)
		{
			var url = "/api/platform/developer/authtickets/?developerAccountId={developerAccountId}";
			FormatUrl( ref url, "developerAccountId", developerAccountId);
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
			var url = "/api/platform/developer/authtickets/?refreshToken={refreshToken}";
			FormatUrl( ref url, "refreshToken", refreshToken);
			return new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD) ;
		}

		
	}
}
