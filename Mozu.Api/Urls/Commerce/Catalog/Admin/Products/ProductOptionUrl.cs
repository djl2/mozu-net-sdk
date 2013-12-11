
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
	public partial class ProductOptionUrl 
	{

		/// <summary>
        /// Get Resource Url for GetOptions
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOptionsUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Options";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetOption
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOptionUrl(string attributeFQN, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Options/{attributeFQN}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddOption
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddOptionUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Options";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateOption
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateOptionUrl(string attributeFQN, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Options/{attributeFQN}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteOption
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteOptionUrl(string attributeFQN, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Options/{attributeFQN}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		
	}
}

