
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
	/// Mozu customers and merchants can create, view, update, and delete attributes for a customer account.
	/// </summary>
	public partial class CustomerAttributeClient 	{
		
		/// <summary>
		/// Retrieves the contents of an attribute associated with the specified customer account.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attribute to retrieve.</param>
		/// <param name="attributeId">Identifier of the customer account attribute to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountAttribute( accountId,  attributeId);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> GetAccountAttributeClient(int accountId, int attributeId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.GetAccountAttributeUrl(accountId, attributeId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// Retrieves the list of customer account attributes.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attributes to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttributeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountAttributes( accountId);
		///   var customerAttributeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection> GetAccountAttributesClient(int accountId)
		{
			return GetAccountAttributesClient( accountId,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves the list of customer account attributes.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attributes to retrieve.</param>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttributeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountAttributes( accountId,  filter,  pageSize,  sortBy,  startIndex);
		///   var customerAttributeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection> GetAccountAttributesClient(int accountId, string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.GetAccountAttributesUrl(accountId, filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

				/// <summary>
		/// Adds a new attribute to associate with the specified customer account.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the new attribute.</param>
		/// <param name="customerAccountAttributes">The properties of the customer account attribute to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountAttributes( accountId,  customerAccountAttributes);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Customer.CustomerAttribute>> AddAccountAttributesClient(int accountId, List<Mozu.Api.Contracts.Customer.CustomerAttribute> customerAccountAttributes)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.AddAccountAttributesUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Customer.CustomerAttribute>>().WithVerb(verb).WithResourceUrl(url).WithBody<List<Mozu.Api.Contracts.Customer.CustomerAttribute>>(customerAccountAttributes);
		return mozuClient;

		}

				/// <summary>
		/// Update a single customer account attribute by providing the customer account ID. This operation can optionally indicate whether or not items missing from the collection should be removed.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attribute.</param>
		/// <param name="customerAccountAttribute">The properties of the customer account attribute being updated.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccountAttribute( accountId,  customerAccountAttribute);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Customer.CustomerAttribute>> UpdateAccountAttributeClient(int accountId, List<Mozu.Api.Contracts.Customer.CustomerAttribute> customerAccountAttribute)
		{
			return UpdateAccountAttributeClient( accountId,  null,  customerAccountAttribute);
		}

		/// <summary>
		/// Update a single customer account attribute by providing the customer account ID. This operation can optionally indicate whether or not items missing from the collection should be removed.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attribute.</param>
		/// <param name="removeMissing">If true, remove the items missing from the collection. If false, do not remove items missing from the collection.</param>
		/// <param name="customerAccountAttribute">The properties of the customer account attribute being updated.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccountAttribute( accountId,  removeMissing,  customerAccountAttribute);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Customer.CustomerAttribute>> UpdateAccountAttributeClient(int accountId, bool? removeMissing, List<Mozu.Api.Contracts.Customer.CustomerAttribute> customerAccountAttribute)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.UpdateAccountAttributeUrl(accountId, removeMissing);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Customer.CustomerAttribute>>().WithVerb(verb).WithResourceUrl(url).WithBody<List<Mozu.Api.Contracts.Customer.CustomerAttribute>>(customerAccountAttribute);
		return mozuClient;

		}

				
	}

}

