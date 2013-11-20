
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
	public partial class LocationInventoryUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for GetLocationInventory
        /// </summary>
        /// <param name="locationCode"></param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationInventoryUrl(string locationCode, string productCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{LocationCode}/{ProductCode}";
			FormatUrl( ref url, "locationCode", locationCode);
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetLocationInventories
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="locationCode"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLocationInventoriesUrl(string filter, string locationCode, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{LocationCode}?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "locationCode", locationCode);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sortBy", sortBy);
			FormatUrl( ref url, "startIndex", startIndex);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for AddLocationInventory
        /// </summary>
        /// <param name="locationCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddLocationInventoryUrl(string locationCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{LocationCode}";
			FormatUrl( ref url, "locationCode", locationCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for UpdateLocationInventory
        /// </summary>
        /// <param name="locationCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateLocationInventoryUrl(string locationCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{locationCode}";
			FormatUrl( ref url, "locationCode", locationCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for DeleteLocationInventory
        /// </summary>
        /// <param name="locationCode"></param>
        /// <param name="productCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteLocationInventoryUrl(string locationCode, string productCode)
		{
			var url = "/api/commerce/catalog/admin/locationinventory/{LocationCode}/{ProductCode}";
			FormatUrl( ref url, "locationCode", locationCode);
			FormatUrl( ref url, "productCode", productCode);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		
	}
}

