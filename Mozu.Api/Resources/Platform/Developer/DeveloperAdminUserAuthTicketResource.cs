
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


namespace Mozu.Api.Resources.Platform.Developer
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DeveloperAdminUserAuthTicketResource  	{
		
				/// <summary>
		/// 
		/// </summary>
		/// <param name="userAuthInfo"></param>
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
		/// 
		/// </summary>
		/// <param name="developerAccountId"></param>
		/// <param name="userAuthInfo"></param>
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
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="existingAuthTicket"></param>
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
		/// 
		/// </summary>
		/// <param name="developerAccountId"></param>
		/// <param name="existingAuthTicket"></param>
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
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshToken"></param>
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
			response= client.Execute();

		}

		
	}

}


