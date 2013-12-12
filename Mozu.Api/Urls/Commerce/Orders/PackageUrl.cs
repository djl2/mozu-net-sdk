
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class PackageUrl 
	{

		/// <summary>
        /// Get Resource Url for GetPackage
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the package to retrieve.</param>
        /// <param name="packageId">Unique identifier of the package to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageUrl(string orderId, string packageId)
		{
			var url = "/api/commerce/orders/{orderId}/packages/{packageId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAvailablePackageFulfillmentActions
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the package fulfillment.</param>
        /// <param name="packageId">Unique identifier of the package associated with the fulfillment actions to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailablePackageFulfillmentActionsUrl(string orderId, string packageId)
		{
			var url = "/api/commerce/orders/{orderId}/packages/{packageId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPackageLabel
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the package label to retrieve.</param>
        /// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPackageLabelUrl(string orderId, string packageId)
		{
			var url = "/api/commerce/orders/{orderId}/packages/{packageId}/label";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreatePackage
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with this package.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreatePackageUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/packages";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdatePackage
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the package to update.</param>
        /// <param name="packageId">Unique identifier of the package of order items to update.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdatePackageUrl(string orderId, string packageId)
		{
			var url = "/api/commerce/orders/{orderId}/packages/{packageId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeletePackage
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the package to delete.</param>
        /// <param name="packageId">Unique identifier of the package to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeletePackageUrl(string orderId, string packageId)
		{
			var url = "/api/commerce/orders/{orderId}/packages/{packageId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "packageId", packageId);
			return mozuUrl;
		}

		
	}
}

