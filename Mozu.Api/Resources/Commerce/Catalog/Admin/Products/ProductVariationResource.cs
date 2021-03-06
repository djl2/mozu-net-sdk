
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Use the product variations sub-resource to manage the variations of a product based on its attributes. For example, a t-shirt product could be offered in six variations: Small Black, Medium Black, Large Black, Small White, Medium White, and Large White.
	/// </summary>
	public partial class ProductVariationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public ProductVariationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the details of a product variation based on the supplied product code and variation key.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariation = productvariation.GetProductVariation(dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariation GetProductVariation(DataViewMode dataViewMode, string productCode, string variationKey)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationClient(dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of the product variations configured for the specified product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationPagedCollection = productvariation.GetProductVariations(dataViewMode,  productCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection GetProductVariations(DataViewMode dataViewMode, string productCode)
		{
			return GetProductVariations(dataViewMode,  productCode,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of the product variations configured for the specified product code.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationPagedCollection = productvariation.GetProductVariations(dataViewMode,  productCode,  startIndex,  pageSize,  sortBy,  filter);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection GetProductVariations(DataViewMode dataViewMode, string productCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.GetProductVariationsClient(dataViewMode,  productCode,  startIndex,  pageSize,  sortBy,  filter);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Modifies the collection of variations for the specified product code. Because this PUT replaces the existing resource, supply all information necessary to maintain for the product variation.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="productVariations">Wrapper for the collection of variations configured for the specified product code.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariationCollection = productvariation.UpdateProductVariations(dataViewMode,  productVariations,  productCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection UpdateProductVariations(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection productVariations, string productCode)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationsClient(dataViewMode,  productVariations,  productCode);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Modifies the details of a variation, based on the supplied variation key, for the specified product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <param name="productVariation">Wrapper for the properties of the specified product variation.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   var productVariation = productvariation.UpdateProductVariation(dataViewMode,  productVariation,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariation UpdateProductVariation(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductVariation productVariation, string productCode, string variationKey)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.UpdateProductVariationClient(dataViewMode,  productVariation,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes a variation, based on the supplied variation key, for the specified product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productvariation = new ProductVariation();
		///   productvariation.DeleteProductVariation(dataViewMode,  productCode,  variationKey);
		/// </code>
		/// </example>
		public virtual void DeleteProductVariation(DataViewMode dataViewMode, string productCode, string variationKey)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductVariationClient.DeleteProductVariationClient(dataViewMode,  productCode,  variationKey);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


