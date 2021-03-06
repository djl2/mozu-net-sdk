
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.AppDev
{
		///
		///	Properties of the authentication ticket used to authenticate applications.
		///
		public class AuthTicket
		{
			///
			///The token that stores an encrypted list of the application's configured behaviors and authenticates the application.
			///
			public string AccessToken { get; set; }

			///
			///Date and time the access token expires. After the access token expires, refresh the authentication ticket using the refresh koken.
			///
			public DateTime AccessTokenExpiration { get; set; }

			///
			///The token that refreshes the application's authentication ticket.
			///
			public string RefreshToken { get; set; }

			///
			///Date and time the refresh token expires. After the refresh token expires, generate a new authentication ticket.
			///
			public DateTime RefreshTokenExpiration { get; set; }

		}

}