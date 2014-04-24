
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
	public partial class OrderAttributeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetOrderAttributes
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for which to retrieve a list of defined attributes.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOrderAttributesUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/attributes";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateOrderAttributes
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for which to assign the attributes.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateOrderAttributesUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/attributes";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateOrderAttributes
        /// </summary>
        /// <param name="orderId">Identifier of the order for which to update attributes.</param>
        /// <param name="removeMissing">If true, the operation removes missing properties so that the updated order attributes will not show properties with a null value.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateOrderAttributesUrl(string orderId, bool? removeMissing)
		{
			var url = "/api/commerce/orders/{orderId}/attributes?removeMissing={removeMissing}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			mozuUrl.FormatUrl( "removeMissing", removeMissing);
			return mozuUrl;
		}

				
	}
}

