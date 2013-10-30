
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
	public partial class ProductPropertyUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetProperties
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetPropertiesUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties";
			FormatUrl( ref url, "productCode", productCode);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetProperty
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetPropertyUrl(string attributeFQN, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			FormatUrl( ref url, "productCode", productCode);
			return url;
		}

				/// <summary>
        /// Get Resource Url for AddProperty
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string AddPropertyUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties";
			FormatUrl( ref url, "productCode", productCode);
			return url;
		}

				/// <summary>
        /// Get Resource Url for UpdateProperty
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdatePropertyUrl(string attributeFQN, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			FormatUrl( ref url, "productCode", productCode);
			return url;
		}

				/// <summary>
        /// Get Resource Url for DeleteProperty
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string DeletePropertyUrl(string attributeFQN, string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Properties/{attributeFQN}";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			FormatUrl( ref url, "productCode", productCode);
			return url;
		}

		
	}
}
