
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.User
{
		///
		///	The user login result contains an authentication token and the list of tenants which is the collection of all the sites that below to that tenant.
		///
		public class UserLoginResult
		{
			///
			///The authentication ticket associated with a user session.
			///
			public UserAuthTicket AuthTicket { get; set; }

		}

}