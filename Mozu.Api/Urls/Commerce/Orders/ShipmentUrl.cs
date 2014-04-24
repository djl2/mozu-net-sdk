
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

namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class ShipmentUrl 
	{

		/// <summary>
        /// Get Resource Url for GetShipment
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the shipment to retrieve.</param>
        /// <param name="shipmentId">Unique identifier of the shipment to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetShipmentUrl(string orderId, string shipmentId)
		{
			var url = "/api/commerce/orders/{orderId}/shipments/{shipmentId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "shipmentId", shipmentId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAvailableShipmentMethods
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for the available shipment methods being retrieved.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailableShipmentMethodsUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/shipments/methods";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreatePackageShipments
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for this shipment.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreatePackageShipmentsUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/shipments";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for DeleteShipment
        /// </summary>
        /// <param name="orderId">Unique identifier of the order to cancel shipment.</param>
        /// <param name="shipmentId">Unique identifier of the shipment to cancel.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteShipmentUrl(string orderId, string shipmentId)
		{
			var url = "/api/commerce/orders/{orderId}/shipments/{shipmentId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "shipmentId", shipmentId);
			return mozuUrl;
		}

		
	}
}

