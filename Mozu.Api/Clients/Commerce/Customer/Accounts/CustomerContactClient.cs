
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

namespace Mozu.Api.Clients.Commerce.Customer.Accounts
{
	/// <summary>
	/// Merchants and customers can create, view, update, and delete a contact for a customer account. A customer account may have multiple contacts for billing and shipping addresses.
	/// </summary>
	public partial class CustomerContactClient 	{
		
		/// <summary>
		/// Retrieves the specified contact for a customer account such as a billing or shipping contact.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being retrieved.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountContact( accountId,  contactId);
		///   var customerContactClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> GetAccountContactClient(int accountId, int contactId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.GetAccountContactUrl(accountId, contactId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContact>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of contacts for a customer according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account associated with the contact information to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountContacts( accountId);
		///   var customerContactCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection> GetAccountContactsClient(int accountId)
		{
			return GetAccountContactsClient( accountId,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of contacts for a customer according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account associated with the contact information to retrieve.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContactCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountContacts( accountId,  filter,  pageSize,  sortBy,  startIndex);
		///   var customerContactCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection> GetAccountContactsClient(int accountId, string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.GetAccountContactsUrl(accountId, filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContactCollection>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

				/// <summary>
		/// Creates a new contact for a customer account such as a new shipping address.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account containing the new contact.</param>
		/// <param name="contact">Properties of the new contact. Required properties: Contact.Email, ContactType.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountContact( accountId,  contact);
		///   var customerContactClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> AddAccountContactClient(int accountId, Mozu.Api.Contracts.Customer.CustomerContact contact)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.AddAccountContactUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContact>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Customer.CustomerContact>(contact);
		return mozuClient;

		}

				/// <summary>
		/// Updates a contact for a specified customer account such as to update addresses or change which contact is the primary contact for billing.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account whose contact information is being updated.</param>
		/// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
		/// <param name="contact">All properties the updated contact will have. Required properties: Name and email address.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerContact"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccountContact( accountId,  contactId,  contact);
		///   var customerContactClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerContact> UpdateAccountContactClient(int accountId, int contactId, Mozu.Api.Contracts.Customer.CustomerContact contact)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.UpdateAccountContactUrl(accountId, contactId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerContact>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Customer.CustomerContact>(contact);
		return mozuClient;

		}

				/// <summary>
		/// Deletes a contact for the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="contactId">Unique identifier of the customer account contact to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAccountContact( accountId,  contactId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAccountContactClient(int accountId, int contactId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerContactUrl.DeleteAccountContactUrl(accountId, contactId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		
	}

}

