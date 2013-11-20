
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


namespace Mozu.Api.Clients.Commerce.Carts
{
	/// <summary>
	/// System messages for live carts to notify the shopper about a product price or inventory change. System-supplied and read-only. For example: Product price is reduced due to a buy one, get one 50% off (BOGO) sale. A message may appear if the product is out of stock during the cart shopping process.
	/// </summary>
	public partial class ChangeMessageClient 	{
		
		/// <summary>
		/// Retrieves messages to and from the current shopper. These are messages supplied by the system to notify the shopper of price increases or decreases or product unavailability.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartChangeMessageCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetMessages(authTicket);
		///   var cartChangeMessageCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartChangeMessageCollection> GetMessagesClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ChangeMessageUrl.GetMessagesUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartChangeMessageCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

								/// <summary>
		/// Deletes all messages associated with the cart of the current shopper.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveAllMessages(authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient RemoveAllMessagesClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ChangeMessageUrl.RemoveAllMessagesUrl();
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Removes a single message associated with the cart of the current shopper.
		/// </summary>
		/// <param name="messageId">Identifier of the message to remove from the cart.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveMessage( messageId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient RemoveMessageClient(string messageId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Carts.ChangeMessageUrl.RemoveMessageUrl(messageId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


