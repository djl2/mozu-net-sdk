
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
		///	Properties of the admin user profile.
		///
		public class UserProfile
		{
			///
			///The email address of the specified user.
			///
			public string EmailAddress { get; set; }

			///
			///The first name of the contact. Max length: 200.
			///
			public string FirstName { get; set; }

			///
			///The last name or surname of the contact. Max length: 200.
			///
			public string LastName { get; set; }

			///
			///Identifier of the user.
			///
			public string UserId { get; set; }

		}

}