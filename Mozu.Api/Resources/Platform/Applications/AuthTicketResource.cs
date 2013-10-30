
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

namespace Mozu.Api.Resources.Platform.Applications
{
	/// <summary>
	/// Use this resource to manage authentication tickets for your applications.
	/// </summary>
	public partial class AuthTicketResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public AuthTicketResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
				/// <summary>
		/// Generate an authentication ticket for an application.
		/// </summary>
		/// <param name="appAuthInfo">Authentication information required to generate an authentication ticket includes the application id and the shared secret.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = authticket.AuthenticateApp( appAuthInfo);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.AppDev.AuthTicket AuthenticateApp(Mozu.Api.Contracts.AppDev.AppAuthInfo appAuthInfo)
		{
						MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.AuthenticateAppClient( appAuthInfo);
			SetContext(_apiContext, ref client,false);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Refreshes the application's authentication ticket and generates a new access token by providing the refresh token string.
		/// </summary>
		/// <param name="authTicketRequest">The refresh token string required to update the application authentication ticket.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.AppDev.AuthTicket"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   var authTicket = authticket.RefreshAppAuthTicket( authTicketRequest);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.AppDev.AuthTicket RefreshAppAuthTicket(Mozu.Api.Contracts.AppDev.AuthTicketRequest authTicketRequest)
		{
						MozuClient<Mozu.Api.Contracts.AppDev.AuthTicket> response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.RefreshAppAuthTicketClient( authTicketRequest);
			SetContext(_apiContext, ref client,false);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Deletes an authentication for an application based on the specified refresh token.
		/// </summary>
		/// <param name="refreshToken">The refresh token string from the application's authentication ticket.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var authticket = new AuthTicket();
		///   authticket.DeleteAppAuthTicket( refreshToken);
		/// </code>
		/// </example>
		public virtual void DeleteAppAuthTicket(string refreshToken)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.DeleteAppAuthTicketClient( refreshToken);
			SetContext(_apiContext, ref client,false);
			response= client.Execute();

		}

		
	}

}

