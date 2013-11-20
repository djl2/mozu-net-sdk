
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Platform.User
{
	public partial class UserUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for GetUserByEmail
        /// </summary>
        /// <param name="emailAddress">The email address of the specified user.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetUserByEmailUrl(string emailAddress)
		{
			var url = "/api/platform/user/accounts/?emailAddress={emailAddress}";
			FormatUrl( ref url, "emailAddress", emailAddress);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetUser
        /// </summary>
        /// <param name="userId">Unique identifier of the user.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetUserUrl(string userId)
		{
			var url = "/api/platform/user/accounts/{userId}";
			FormatUrl( ref url, "userId", userId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for CreateUser
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateUserUrl()
		{
			var url = "/api/platform/user/accounts/";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for CreateUsers
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateUsersUrl()
		{
			var url = "/api/platform/user/accounts/Bulk";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for Login
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl LoginUrl()
		{
			var url = "/api/platform/user/accounts/Login";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for ResetPassword
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ResetPasswordUrl()
		{
			var url = "/api/platform/user/accounts/resetpassword";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

						
	}
}

