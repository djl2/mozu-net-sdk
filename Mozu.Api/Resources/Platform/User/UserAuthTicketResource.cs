
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


namespace Mozu.Api.Resources.Platform.User
{
	/// <summary>
	/// 
	/// </summary>
	public partial class UserAuthTicketResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public UserAuthTicketResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
				/// <summary>
		/// 
		/// </summary>
		/// <param name="userAuthInfo"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.UserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var userauthticket = new UserAuthTicket();
		///   var userAuthTicket = userauthticket.CreateUserAuthTicket( userAuthInfo);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.UserAuthTicket CreateUserAuthTicket(Mozu.Api.Contracts.Core.UserAuthInfo userAuthInfo)
		{
			MozuClient<Mozu.Api.Contracts.Core.UserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.User.UserAuthTicketClient.CreateUserAuthTicketClient( userAuthInfo);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userAuthInfo"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.UserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var userauthticket = new UserAuthTicket();
		///   var userAuthTicket = userauthticket.CreateAuthTicketForSite( userAuthInfo);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.UserAuthTicket CreateAuthTicketForSite(Mozu.Api.Contracts.Core.UserTokenInfo userAuthInfo)
		{
			MozuClient<Mozu.Api.Contracts.Core.UserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.User.UserAuthTicketClient.CreateAuthTicketForSiteClient( userAuthInfo);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="refreshToken"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.UserAuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var userauthticket = new UserAuthTicket();
		///   var userAuthTicket = userauthticket.RefreshUserAuthTicket( refreshToken);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.UserAuthTicket RefreshUserAuthTicket(string refreshToken)
		{
			MozuClient<Mozu.Api.Contracts.Core.UserAuthTicket> response;
			var client = Mozu.Api.Clients.Platform.User.UserAuthTicketClient.RefreshUserAuthTicketClient( refreshToken);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				
	}

}


