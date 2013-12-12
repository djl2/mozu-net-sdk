
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
	/// Use the Product Types resource to manage the types for your product catalog. Product types act as configuration templates, which store a set of attributes common to all products associated with that type. Unlike categories, products can only be associated with a single product type.
	/// </summary>
	public partial class ProductTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public ProductTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of product types according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productTypeCollection = producttype.GetProductTypes(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection GetProductTypes(DataViewMode dataViewMode)
		{
			return GetProductTypes(dataViewMode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of product types according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product type search results by any of its properties. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=Name+cont+shoes"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productTypeCollection = producttype.GetProductTypes(dataViewMode,  startIndex,  pageSize,  sortBy,  filter, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection GetProductTypes(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.GetProductTypesClient(dataViewMode,  startIndex,  pageSize,  sortBy,  filter, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the product type specified in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type to retrieve.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = producttype.GetProductType(dataViewMode,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductType GetProductType(DataViewMode dataViewMode, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.GetProductTypeClient(dataViewMode,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new product type based on the information supplied in the request.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productType">Properties of the product type to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = producttype.AddProductType(dataViewMode,  productType, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductType AddProductType(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductType productType, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.AddProductTypeClient(dataViewMode,  productType, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of a product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type to update.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productType">The details of the product type to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = producttype.UpdateProductType(dataViewMode,  productType,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductType UpdateProductType(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductType productType, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.UpdateProductTypeClient(dataViewMode,  productType,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes the product type by providing the product type ID.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type to delete.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   producttype.DeleteProductType(dataViewMode,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteProductType(DataViewMode dataViewMode, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.DeleteProductTypeClient(dataViewMode,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


