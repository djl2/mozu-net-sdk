
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.Core
{
		///
		///	Information required to authenticate a user.
		///
		public class UserAuthInfo
		{
			///
			///The email address of the specified user or the email address associated with the specified entity.
			///
			public string EmailAddress { get; set; }

			///
			///Password of the user.
			///
			public string Password { get; set; }

		}

}