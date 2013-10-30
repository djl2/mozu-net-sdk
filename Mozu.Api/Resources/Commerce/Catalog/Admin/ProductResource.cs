
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use this resource to create products, view the attributes associated with existing products, and determine which sites feature a specific product.
	/// </summary>
	public partial class ProductResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public ProductResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of products according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productCollection = product.GetProducts();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductCollection GetProducts()
		{
			return GetProducts( null,  null,  null,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of products according to any specified facets, filter criteria, and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="noCount">If true, the operation does not return the TotalCount number of results.</param>
		/// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of product search terms to use in the query when searching across product code and product name. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productCollection = product.GetProducts( filter,  noCount,  pageSize,  q,  qLimit,  sortBy,  startIndex);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductCollection GetProducts(string filter, bool? noCount, int? pageSize, string q, int? qLimit, string sortBy, int? startIndex)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductsClient( filter,  noCount,  pageSize,  q,  qLimit,  sortBy,  startIndex);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves an existing product.
		/// </summary>
		/// <param name="productCode">Merchant-created code associated with the product such as a SKU. Max length: 30. Accepts a to z, A to Z, Ãƒâ€¹-ÃƒËœ, 0 to 9, #, semicolon, commas, apostrophes, and Spaces, but no punctuation or other characters.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.GetProduct( productCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Product GetProduct(string productCode)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductClient( productCode);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a product that is associated with more than one specific site.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInSiteInfo = product.GetProductInSites( productCode);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo> GetProductInSites(string productCode)
		{
						MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductInSitesClient( productCode);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a product that is associated with a specific site ID.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="siteId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInSiteInfo = product.GetProductInSite( productCode,  siteId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo GetProductInSite(string productCode, int siteId)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.GetProductInSiteClient( productCode,  siteId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Creates a new product. Supply a product name, product code, price and other product characteristics such as its attributes, categories where the product belongs, whether the product has configurable options, stand-alone options, and so on.
		/// </summary>
		/// <param name="product">Properties of the new product. Required properties: ProductCode, Content.ProductName, and Price.ListPrice.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.AddProduct( product);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Product AddProduct(Mozu.Api.Contracts.ProductAdmin.Product product)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.AddProductClient( product);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new product and assigns it to a specific site.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="productInSiteInfoIn">Creates a new product to associate with a site by updating the properties of that product by product ID.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInSiteInfo = product.AddProductInSite( productCode,  productInSiteInfoIn);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo AddProductInSite(string productCode, Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo productInSiteInfoIn)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.AddProductInSiteClient( productCode,  productInSiteInfoIn);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the inventory for an existing product. The inventory or stock adjustment value is either an absolute number (number of items in stock) or Delta (the number to subtract from or add to the current number of items in stock).
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="stockAdjustment">Inventory adjustment for the product. Must supply Type (either Absolute or Delta) and Value (number of items to adjust). If Delta, specify a negative number to subtract inventory.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.UpdateProductStock( productCode,  stockAdjustment);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Product UpdateProductStock(string productCode, Mozu.Api.Contracts.ProductAdmin.StockOnHandAdjustment stockAdjustment)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductStockClient( productCode,  stockAdjustment);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Modifies an existing product.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="product">Properties of the product to update. Required properties: ProductCode, Content.ProductName, and Price.ListPrice.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Product"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var product = product.UpdateProduct( productCode,  product);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Product UpdateProduct(string productCode, Mozu.Api.Contracts.ProductAdmin.Product product)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.Product> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductClient( productCode,  product);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Modifies an existing product that is associated with more than one specific site. For example, to link an existing product that is already associated to a site to another site, use this operation to create that association.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="productInSitesIn">Modifies an existing product associated with more than one site by updating the properties of that product by product ID.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInSiteInfo = product.UpdateProductInSites( productCode,  productInSitesIn);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo> UpdateProductInSites(string productCode, List<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo> productInSitesIn)
		{
						MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductInSitesClient( productCode,  productInSitesIn);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Modifies an existing product associated with a specific site ID.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="siteId"></param>
		/// <param name="productInSiteInfoIn">Modifies an existing product associated with a site by updating the properties of that product by product ID.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   var productInSiteInfo = product.UpdateProductInSite( productCode,  siteId,  productInSiteInfoIn);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo UpdateProductInSite(string productCode, int siteId, Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo productInSiteInfoIn)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductInSiteInfo> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.UpdateProductInSiteClient( productCode,  siteId,  productInSiteInfoIn);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Deletes the product specified by its product code.
		/// </summary>
		/// <param name="productCode">Merchant-created code associated with the product such as a SKU.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   product.DeleteProduct( productCode);
		/// </code>
		/// </example>
		public virtual void DeleteProduct(string productCode)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.DeleteProductClient( productCode);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

		/// <summary>
		/// Deletes the product specified by its product code and based on the site it has been associated with.
		/// </summary>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="siteId"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var product = new Product();
		///   product.DeleteProductInSite( productCode,  siteId);
		/// </code>
		/// </example>
		public virtual void DeleteProductInSite(string productCode, int siteId)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductClient.DeleteProductInSiteClient( productCode,  siteId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

		
	}

}

