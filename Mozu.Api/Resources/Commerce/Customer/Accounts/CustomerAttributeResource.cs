
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

namespace Mozu.Api.Resources.Commerce.Customer.Accounts
{
	/// <summary>
	/// Mozu customers and merchants can create, view, update, and delete attributes for a customer account.
	/// </summary>
	public partial class CustomerAttributeResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public CustomerAttributeResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the contents of an attribute associated with the specified customer account.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attribute to retrieve.</param>
		/// <param name="attributeId">Identifier of the customer account attribute to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerattribute = new CustomerAttribute();
		///   var customerAttribute = customerattribute.GetAccountAttribute( accountId,  attributeId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerAttribute GetAccountAttribute(int accountId, int attributeId)
		{
						MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerAttributeClient.GetAccountAttributeClient( accountId,  attributeId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of customer account attributes.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attributes to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAttributeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerattribute = new CustomerAttribute();
		///   var customerAttributeCollection = customerattribute.GetAccountAttributes( accountId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerAttributeCollection GetAccountAttributes(int accountId)
		{
			return GetAccountAttributes( accountId,  null,  null,  null,  null);
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
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerAttributeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerattribute = new CustomerAttribute();
		///   var customerAttributeCollection = customerattribute.GetAccountAttributes( accountId,  filter,  pageSize,  sortBy,  startIndex);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.CustomerAttributeCollection GetAccountAttributes(int accountId, string filter, int? pageSize, string sortBy, int? startIndex)
		{
						MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerAttributeClient.GetAccountAttributesClient( accountId,  filter,  pageSize,  sortBy,  startIndex);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Adds a new attribute to associate with the specified customer account.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the new attribute.</param>
		/// <param name="customerAccountAttributes">The properties of the customer account attribute to create.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var customerattribute = new CustomerAttribute();
		///   var customerAttribute = customerattribute.AddAccountAttributes( accountId,  customerAccountAttributes);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Customer.CustomerAttribute> AddAccountAttributes(int accountId, List<Mozu.Api.Contracts.Customer.CustomerAttribute> customerAccountAttributes)
		{
						MozuClient<List<Mozu.Api.Contracts.Customer.CustomerAttribute>> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerAttributeClient.AddAccountAttributesClient( accountId,  customerAccountAttributes);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Update a single customer account attribute by providing the customer account ID. This operation can optionally indicate whether or not items missing from the collection should be removed.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attribute.</param>
		/// <param name="customerAccountAttribute">The properties of the customer account attribute being updated.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var customerattribute = new CustomerAttribute();
		///   var customerAttribute = customerattribute.UpdateAccountAttribute( accountId,  customerAccountAttribute);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Customer.CustomerAttribute> UpdateAccountAttribute(int accountId, List<Mozu.Api.Contracts.Customer.CustomerAttribute> customerAccountAttribute)
		{
			return UpdateAccountAttribute( accountId,  null,  customerAccountAttribute);
		}

		/// <summary>
		/// Update a single customer account attribute by providing the customer account ID. This operation can optionally indicate whether or not items missing from the collection should be removed.
		/// </summary>
		/// <param name="accountId">Identifier of the customer account associated with the attribute.</param>
		/// <param name="removeMissing">If true, remove the items missing from the collection. If false, do not remove items missing from the collection.</param>
		/// <param name="customerAccountAttribute">The properties of the customer account attribute being updated.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var customerattribute = new CustomerAttribute();
		///   var customerAttribute = customerattribute.UpdateAccountAttribute( accountId,  removeMissing,  customerAccountAttribute);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Customer.CustomerAttribute> UpdateAccountAttribute(int accountId, bool? removeMissing, List<Mozu.Api.Contracts.Customer.CustomerAttribute> customerAccountAttribute)
		{
						MozuClient<List<Mozu.Api.Contracts.Customer.CustomerAttribute>> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerAttributeClient.UpdateAccountAttributeClient( accountId,  removeMissing,  customerAccountAttribute);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				
	}

}

