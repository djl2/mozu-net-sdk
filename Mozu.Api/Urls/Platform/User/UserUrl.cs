
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
	public partial class UserUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetUserByEmail
        /// </summary>
        /// <param name="emailAddress">The email address of the specified user or the email address associated with the specified entity.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetUserByEmailUrl(string emailAddress)
		{
			var url = "/api/platform/user/accounts/?emailAddress={emailAddress}";
			FormatUrl( ref url, "emailAddress", emailAddress);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetUser
        /// </summary>
        /// <param name="userId">Unique identifier of the user.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetUserUrl(string userId)
		{
			var url = "/api/platform/user/accounts/{userId}";
			FormatUrl( ref url, "userId", userId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for CreateUser
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string CreateUserUrl()
		{
			var url = "/api/platform/user/accounts/";
			return url;
		}

		/// <summary>
        /// Get Resource Url for CreateUsers
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string CreateUsersUrl()
		{
			var url = "/api/platform/user/accounts/Bulk";
			return url;
		}

		/// <summary>
        /// Get Resource Url for Login
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string LoginUrl()
		{
			var url = "/api/platform/user/accounts/Login";
			return url;
		}

		/// <summary>
        /// Get Resource Url for ResetPassword
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string ResetPasswordUrl()
		{
			var url = "/api/platform/user/accounts/resetpassword";
			return url;
		}

						
	}
}

