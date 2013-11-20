
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


namespace Mozu.Api.Clients.Commerce.Customer.Accounts
{
	/// <summary>
	/// Use the Cards subresource to manage stored credit cards for customer accounts. Mozu stores limited card data in the Customer service for expedited ordering purposes; however, the complete card data is stored in the Payment service.
	/// </summary>
	public partial class CardClient 	{
		
		/// <summary>
		/// Retrieves all stored credit cards for the customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CardCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountCards( accountId, authTicket);
		///   var cardCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CardCollection> GetAccountCardsClient(int accountId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CardUrl.GetAccountCardsUrl(accountId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CardCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Creates a new credit card record and stores it for the customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="card">Properties of the customer credit card to add to the account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Card"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountCard( card,  accountId, authTicket);
		///   var cardClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Card> AddAccountCardClient(Mozu.Api.Contracts.Customer.Card card, int accountId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CardUrl.AddAccountCardUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Card>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Customer.Card>(card);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Update one or more properties of a credit card defined for a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="card">Properties of the customer account credit card to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.Card"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccountCard( card,  accountId, authTicket);
		///   var cardClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.Card> UpdateAccountCardClient(Mozu.Api.Contracts.Customer.Card card, int accountId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CardUrl.UpdateAccountCardUrl(accountId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.Card>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Customer.Card>(card);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Removes a stored credit card from a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="cardId">Unique identifier of the credit card to delete.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAccountCard( accountId,  cardId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAccountCardClient(int accountId, string cardId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CardUrl.DeleteAccountCardUrl(accountId, cardId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


