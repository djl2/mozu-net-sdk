
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Catalog.Storefront
{
	public partial class ProductUrl 
	{

		/// <summary>
        /// Get Resource Url for GetProducts
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/catalog/storefront/products/?filter={filter}&startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProductInventory
        /// </summary>
        /// <param name="locationCodes">Array of location codes for which to retrieve product inventory information.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInventoryUrl(string locationCodes, string productCode)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/locationinventory?locationCodes={locationCodes}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "locationCodes", locationCodes);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetProduct
        /// </summary>
        /// <param name="allowInactive">If true, returns an inactive product as part of the query.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="skipInventoryCheck"></param>
        /// <param name="variationProductCode">Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductUrl(bool? allowInactive, string productCode, bool? skipInventoryCheck, string variationProductCode)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}?variationProductCode={variationProductCode}&allowInactive={allowInactive}&skipInventoryCheck={skipInventoryCheck}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "allowInactive", allowInactive);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			mozuUrl.FormatUrl( "variationProductCode", variationProductCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for ConfiguredProduct
        /// </summary>
        /// <param name="includeOptionDetails">If true, the response returns details about the product. If false, returns a product summary such as the product name, price, and sale price.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="skipInventoryCheck"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ConfiguredProductUrl(bool? includeOptionDetails, string productCode, bool? skipInventoryCheck)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/configure?includeOptionDetails={includeOptionDetails}&skipInventoryCheck={skipInventoryCheck}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "includeOptionDetails", includeOptionDetails);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateProduct
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="skipInventoryCheck"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateProductUrl(string productCode, bool? skipInventoryCheck)
		{
			var url = "/api/commerce/catalog/storefront/products/{productCode}/validate?skipInventoryCheck={skipInventoryCheck}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "skipInventoryCheck", skipInventoryCheck);
			return mozuUrl;
		}

						
	}
}

