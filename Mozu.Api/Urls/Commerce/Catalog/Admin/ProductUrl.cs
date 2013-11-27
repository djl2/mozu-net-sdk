
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class ProductUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for GetProducts
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="noCount"></param>
        /// <param name="pageSize"></param>
        /// <param name="q"></param>
        /// <param name="qLimit"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductsUrl(string filter, bool? noCount, int? pageSize, string q, int? qLimit, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/catalog/admin/products/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&q={q}&qLimit={qLimit}&noCount={noCount}";
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "noCount", noCount);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "q", q);
			FormatUrl( ref url, "qLimit", qLimit);
			FormatUrl( ref url, "sortBy", sortBy);
			FormatUrl( ref url, "startIndex", startIndex);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetProduct
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}";
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetProductInCatalogs
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInCatalogsUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs";
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetProductInCatalog
        /// </summary>
        /// <param name="catalogId"></param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetProductInCatalogUrl(int catalogId, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs/{catalogId}";
			FormatUrl( ref url, "catalogId", catalogId);
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for AddProduct
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddProductUrl()
		{
			var url = "/api/commerce/catalog/admin/products/";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for AddProductInCatalog
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddProductInCatalogUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs";
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for UpdateProduct
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateProductUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}";
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for UpdateProductInCatalogs
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateProductInCatalogsUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs";
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for UpdateProductInCatalog
        /// </summary>
        /// <param name="catalogId"></param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateProductInCatalogUrl(int catalogId, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs/{catalogId}";
			FormatUrl( ref url, "catalogId", catalogId);
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for DeleteProduct
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteProductUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}";
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for DeleteProductInCatalog
        /// </summary>
        /// <param name="catalogId"></param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteProductInCatalogUrl(int catalogId, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/ProductInCatalogs/{catalogId}";
			FormatUrl( ref url, "catalogId", catalogId);
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		
	}
}

