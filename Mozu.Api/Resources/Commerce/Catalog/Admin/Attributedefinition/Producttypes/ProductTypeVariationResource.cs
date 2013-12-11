
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Producttypes
{
	/// <summary>
	/// Use the variations resource to preview possible product variations for a specific product type based on the option attributes defined for the product type, such as size or color.
	/// </summary>
	public partial class ProductTypeVariationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public ProductTypeVariationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Generates the variations possible for a product associated with the product type based on the option values supplied in the request.
		/// </summary>
		/// <param name="productTypeId">Unique identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productOptionsIn">The product option attributes configured for this product type.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypevariation = new ProductTypeVariation();
		///   var productVariationPagedCollection = producttypevariation.GenerateProductVariations(dataViewMode,  productOptionsIn,  productTypeId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection GenerateProductVariations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductOption> productOptionsIn, int productTypeId)
		{
			return GenerateProductVariations(dataViewMode,  productOptionsIn,  productTypeId,  null,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Generates the variations possible for a product associated with the product type based on the option values supplied in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="productCode"></param>
		/// <param name="productTypeId">Unique identifier of the product type.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productOptionsIn">The product option attributes configured for this product type.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypevariation = new ProductTypeVariation();
		///   var productVariationPagedCollection = producttypevariation.GenerateProductVariations(dataViewMode,  productOptionsIn,  productTypeId,  productCode,  startIndex,  pageSize,  sortBy,  filter, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection GenerateProductVariations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductOption> productOptionsIn, int productTypeId, string productCode =  null, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeVariationClient.GenerateProductVariationsClient(dataViewMode,  productOptionsIn,  productTypeId,  productCode,  startIndex,  pageSize,  sortBy,  filter, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


