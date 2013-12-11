
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


namespace Mozu.Api.Resources.Commerce.Customer.Accounts
{
	/// <summary>
	/// Merchants and customers can create, view, update, and delete a contact for a customer account. A customer account may have multiple contacts for billing and shipping addresses.
	/// </summary>
	public partial class CustomerContactResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public CustomerContactResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the specified contact for a customer account such as a billing or shipping contact.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being retrieved.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to retrieve.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = customercontact.GetAccountContact( accountId,  contactId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerContact GetAccountContact(int accountId, int contactId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.GetAccountContactClient( accountId,  contactId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of contacts for a customer according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account associated with the contact information to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContactCollection = customercontact.GetAccountContacts( accountId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerContactCollection GetAccountContacts(int accountId)
		{
			return GetAccountContacts( accountId,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of contacts for a customer according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account associated with the contact information to retrieve.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContactCollection = customercontact.GetAccountContacts( accountId,  startIndex,  pageSize,  sortBy,  filter, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerContactCollection GetAccountContacts(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.GetAccountContactsClient( accountId,  startIndex,  pageSize,  sortBy,  filter, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new contact for a customer account such as a new shipping address.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account containing the new contact.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="contact">Properties of the new contact. Required properties: Contact.Email, ContactType.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = customercontact.AddAccountContact( contact,  accountId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerContact AddAccountContact(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.AddAccountContactClient( contact,  accountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates a contact for a specified customer account such as to update addresses or change which contact is the primary contact for billing.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being updated.</param>
		/// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="contact">All properties the updated contact will have. Required properties: Name and email address.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   var customerContact = customercontact.UpdateAccountContact( contact,  accountId,  contactId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerContact UpdateAccountContact(Mozu.Api.Contracts.Customer.CustomerContact contact, int accountId, int contactId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.UpdateAccountContactClient( contact,  accountId,  contactId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes a contact for the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to delete.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customercontact = new CustomerContact();
		///   customercontact.DeleteAccountContact( accountId,  contactId, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteAccountContact(int accountId, int contactId, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerContactClient.DeleteAccountContactClient( accountId,  contactId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


