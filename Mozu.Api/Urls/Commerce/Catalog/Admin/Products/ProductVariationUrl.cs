
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Products
{
	public partial class ProductVariationUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetProductVariation
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetProductVariationUrl(string productCode, string variationKey)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/variations/{variationKey}";
			FormatUrl( ref url, "productCode", productCode);
			FormatUrl( ref url, "variationKey", variationKey);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetProductVariations
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">Indicates the zero-based offset in the complete result set where the returned entities begin, when creating paged results from a query. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetProductVariationsUrl(string filter, int? pageSize, string productCode, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/variations?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "productCode", productCode);
			FormatUrl( ref url, "sortBy", sortBy);
			FormatUrl( ref url, "startIndex", startIndex);
			return url;
		}

						/// <summary>
        /// Get Resource Url for UpdateProductVariations
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateProductVariationsUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/variations";
			FormatUrl( ref url, "productCode", productCode);
			return url;
		}

		/// <summary>
        /// Get Resource Url for UpdateProductVariation
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateProductVariationUrl(string productCode, string variationKey)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/variations/{variationKey}";
			FormatUrl( ref url, "productCode", productCode);
			FormatUrl( ref url, "variationKey", variationKey);
			return url;
		}

				/// <summary>
        /// Get Resource Url for DeleteProductVariation
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="variationKey">System-generated key that represents the attribute values that uniquely identify a specific product variation.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string DeleteProductVariationUrl(string productCode, string variationKey)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/variations/{variationKey}";
			FormatUrl( ref url, "productCode", productCode);
			FormatUrl( ref url, "variationKey", variationKey);
			return url;
		}

		
	}
}
