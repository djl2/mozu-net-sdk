
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Platform.Adminuser
{
	/// <summary>
	/// 
	/// </summary>
	public partial class AdminUserClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.User"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUser( userId, authTicket);
		///   var userClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.User> GetUserClient(string userId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Platform.Adminuser.AdminUserUrl.GetUserUrl(userId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.User>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Tenant.TenantCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTenantScopesForUser( userId, authTicket);
		///   var tenantCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Tenant.TenantCollection> GetTenantScopesForUserClient(string userId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Platform.Adminuser.AdminUserUrl.GetTenantScopesForUserUrl(userId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Tenant.TenantCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

								
	}

}


