
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


namespace Mozu.Api.Clients.Platform.Developer
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DeveloperAdminUserAuthTicketClient 	{
		
				/// <summary>
		/// 
		/// </summary>
		/// <param name="userAuthInfo"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDeveloperUserAuthTicket( userAuthInfo);
		///   var developerAdminUserAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> CreateDeveloperUserAuthTicketClient(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo)
		{
			return CreateDeveloperUserAuthTicketClient( userAuthInfo,  null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="developerAccountId"></param>
		/// <param name="userAuthInfo"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDeveloperUserAuthTicket( userAuthInfo,  developerAccountId);
		///   var developerAdminUserAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> CreateDeveloperUserAuthTicketClient(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo, int? developerAccountId =  null)
		{
			var url = Mozu.Api.Urls.Platform.Developer.DeveloperAdminUserAuthTicketUrl.CreateDeveloperUserAuthTicketUrl(developerAccountId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Core.UserAuthInfo>(userAuthInfo);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="existingAuthTicket"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RefreshDeveloperAuthTicket( existingAuthTicket);
		///   var developerAdminUserAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> RefreshDeveloperAuthTicketClient(Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket existingAuthTicket)
		{
			return RefreshDeveloperAuthTicketClient( existingAuthTicket,  null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="developerAccountId"></param>
		/// <param name="existingAuthTicket"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RefreshDeveloperAuthTicket( existingAuthTicket,  developerAccountId);
		///   var developerAdminUserAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket> RefreshDeveloperAuthTicketClient(Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket existingAuthTicket, int? developerAccountId =  null)
		{
			var url = Mozu.Api.Urls.Platform.Developer.DeveloperAdminUserAuthTicketUrl.RefreshDeveloperAuthTicketUrl(developerAccountId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.AdminUser.DeveloperAdminUserAuthTicket>(existingAuthTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshToken"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteUserAuthTicket( refreshToken);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteUserAuthTicketClient(string refreshToken)
		{
			var url = Mozu.Api.Urls.Platform.Developer.DeveloperAdminUserAuthTicketUrl.DeleteUserAuthTicketUrl(refreshToken);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			return mozuClient;

		}

		
	}

}

