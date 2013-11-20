
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition
{
	/// <summary>
	/// Attributes allow a merchant to define a product base type by extending product details. Define details, such as specifications, to describe products. Create attributes to share across several or all products in a store or stores such as price, size, weight, color, and brand. Some attributes will apply to a specific type of product or a single product, for example, screen resolution or storage capacity. Create attributes separately from products to share common attributes across products. <br></br> Attributes are options, extras, and properties. Options are a a grouping of option values. Products with options do not produce child products with unique SKU's. Options themselves are not tied to inventory. However, they are tied to a product and are only available in the cart when a product is being added, updated, or removed. Examples: color or size. <br></br> Option values are the choices available in an option group. Examples: red, blue, green or small, medium, large. <br></br> Extras are product details to add on to the product itself. Examples: Upgrades, monogram. Properties are Examples: Brand name or UPC Code.
	/// </summary>
	public partial class AttributeResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public AttributeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a paged list of attributes according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attributeCollection = attribute.GetAttributes(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeCollection GetAttributes(DataViewMode dataViewMode)
		{
			return GetAttributes(dataViewMode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a paged list of attributes according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">"A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - ""filter=IsDisplayed+eq+true"""</param>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attributeCollection = attribute.GetAttributes(dataViewMode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeCollection GetAttributes(DataViewMode dataViewMode, string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.GetAttributesClient(dataViewMode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves summary details of a single attribute, such as whether it's required, has multiple values, or is entered by the shopper. Another operation retrieves the attribute's list of attribute values.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Attribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attribute = attribute.GetAttribute(dataViewMode,  attributeFQN, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Attribute GetAttribute(DataViewMode dataViewMode, string attributeFQN, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.GetAttributeClient(dataViewMode,  attributeFQN, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Creates a new attribute to describe one aspect of a product such as color or size. Specify several properties when creating the attribute. Include its display name, whether it represents a product option that a shopper selects when purchasing it, or whether the shopper supplies the value (if required to do so), such as engraved initials. Include how attribute values should appear on the storefront such as via radio buttons or text boxes.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="attribute">Properties of the attribute to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Attribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attribute = attribute.AddAttribute(dataViewMode,  attribute, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Attribute AddAttribute(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Attribute attribute, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.AddAttributeClient(dataViewMode,  attribute, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Updates an existing attribute with attribute properties to set.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="attribute">Any properties of the attribute that to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Attribute"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   var attribute = attribute.UpdateAttribute(dataViewMode,  attribute,  attributeFQN, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Attribute UpdateAttribute(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Attribute attribute, string attributeFQN, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Attribute> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.UpdateAttributeClient(dataViewMode,  attribute,  attributeFQN, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Deletes an existing attribute.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var attribute = new Attribute();
		///   attribute.DeleteAttribute(dataViewMode,  attributeFQN, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteAttribute(DataViewMode dataViewMode, string attributeFQN, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.DeleteAttributeClient(dataViewMode,  attributeFQN, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


