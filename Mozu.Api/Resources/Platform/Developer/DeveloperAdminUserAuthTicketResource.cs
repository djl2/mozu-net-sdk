
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;


namespace Mozu.Api.Resources.Platform.Developer
{
	/// <summary>
	/// Use this resource to manage authentication tickets for your developer account.
	/// </summary>
	public partial class DeveloperAdminUserAuthTicketResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public DeveloperAdminUserAuthTicketResource() 
		{
			_apiContext = null;
		}
		 public DeveloperAdminUserAuthTicketResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Generate an authentication ticket for a developer account.
		/// </summary>
		/// <param name="userAuthInfo">The user authentication information required to generate the developer account user authentication ticket, which consists of a user name and password.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var developeradminuserauthticket = new DeveloperAdminUserAuthTicket();
		///   var developerAdminUserAuthTicket = developeradminuserauthticket.CreateDeveloperUserAuthTicket( userAuthInfo);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket CreateDeveloperUserAuthTicket(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo)
		{
			return CreateDeveloperUserAuthTicket( userAuthInfo,  null);
		}

		/// <summary>
		/// Generate an authentication ticket for a developer account.
		/// </summary>
		/// <param name="developerAccountId">Unique identifier of the developer account.</param>
		/// <param name="userAuthInfo">The user authentication information required to generate the developer account user authentication ticket, which consists of a user name and password.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var developeradminuserauthticket = new DeveloperAdminUserAuthTicket();
		///   var developerAdminUserAuthTicket = developeradminuserauthticket.CreateDeveloperUserAuthTicket( userAuthInfo,  developerAccountId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket CreateDeveloperUserAuthTicket(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? developerAccountId =  null)
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Developer.DeveloperAdminUserAuthTicketClient.CreateDeveloperUserAuthTicketClient( userAuthInfo,  developerAccountId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Generates a new developer account authentication ticket for the specified tenant by supplying the defined refresh token information.
		/// </summary>
		/// <param name="existingAuthTicket">Properties of the authentication ticket to refresh. The refresh token is required to complete this request.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var developeradminuserauthticket = new DeveloperAdminUserAuthTicket();
		///   var developerAdminUserAuthTicket = developeradminuserauthticket.RefreshDeveloperAuthTicket( existingAuthTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket RefreshDeveloperAuthTicket(Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket existingAuthTicket)
		{
			return RefreshDeveloperAuthTicket( existingAuthTicket,  null);
		}

		/// <summary>
		/// Generates a new developer account authentication ticket for the specified tenant by supplying the defined refresh token information.
		/// </summary>
		/// <param name="developerAccountId">Unique identifier of the developer account.</param>
		/// <param name="existingAuthTicket">Properties of the authentication ticket to refresh. The refresh token is required to complete this request.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var developeradminuserauthticket = new DeveloperAdminUserAuthTicket();
		///   var developerAdminUserAuthTicket = developeradminuserauthticket.RefreshDeveloperAuthTicket( existingAuthTicket,  developerAccountId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket RefreshDeveloperAuthTicket(Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket existingAuthTicket, int? developerAccountId =  null)
		{
			MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Developer.DeveloperAdminUserAuthTicketClient.RefreshDeveloperAuthTicketClient( existingAuthTicket,  developerAccountId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes the authentication ticket for the developer account by supplying the refresh token.
		/// </summary>
		/// <param name="refreshToken">Refresh token string associated with the developer account authentication ticket.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var developeradminuserauthticket = new DeveloperAdminUserAuthTicket();
		///   developeradminuserauthticket.DeleteUserAuthTicket( refreshToken);
		/// </code>
		/// </example>
		public virtual void DeleteUserAuthTicket(string refreshToken)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Developer.DeveloperAdminUserAuthTicketClient.DeleteUserAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


