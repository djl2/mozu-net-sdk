
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


namespace Mozu.Api.Resources.Commerce.Carts
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ChangeMessageResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public ChangeMessageResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartChangeMessageCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var changemessage = new ChangeMessage();
		///   var cartChangeMessageCollection = changemessage.GetMessages(authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartChangeMessageCollection GetMessages(AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartChangeMessageCollection> response;
			var client = Mozu.Api.Clients.Commerce.Carts.ChangeMessageClient.GetMessagesClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

								/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var changemessage = new ChangeMessage();
		///   changemessage.RemoveAllMessages(authTicket);
		/// </code>
		/// </example>
		public virtual void RemoveAllMessages(AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Carts.ChangeMessageClient.RemoveAllMessagesClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="messageId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var changemessage = new ChangeMessage();
		///   changemessage.RemoveMessage( messageId, authTicket);
		/// </code>
		/// </example>
		public virtual void RemoveMessage(string messageId, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Carts.ChangeMessageClient.RemoveMessageClient( messageId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


