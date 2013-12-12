
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Platform.Applications
{
	public partial class AuthTicketUrl 
	{

				/// <summary>
        /// Get Resource Url for AuthenticateApp
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AuthenticateAppUrl()
		{
			var url = "/api/platform/applications/authtickets/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for RefreshAppAuthTicket
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RefreshAppAuthTicketUrl()
		{
			var url = "/api/platform/applications/authtickets/refresh-ticket";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteAppAuthTicket
        /// </summary>
        /// <param name="refreshToken">The refresh token string from the application's authentication ticket.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteAppAuthTicketUrl(string refreshToken)
		{
			var url = "/api/platform/applications/authtickets/{refreshToken}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.HOME_POD, false) ;
			mozuUrl.FormatUrl( "refreshToken", refreshToken);
			return mozuUrl;
		}

		
	}
}

