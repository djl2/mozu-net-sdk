
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
	public partial class OrderNoteUrl 
	{

		/// <summary>
        /// Get Resource Url for GetOrderNotes
        /// </summary>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOrderNotesUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/notes";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetOrderNote
        /// </summary>
        /// <param name="noteId">Unique identifier of the order note to retrieve.</param>
        /// <param name="orderId">Unique identifier of the order associated with the note.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetOrderNoteUrl(string noteId, string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/notes/{noteId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "noteId", noteId);
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateOrderNote
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for which to add a note.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateOrderNoteUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/notes";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateOrderNote
        /// </summary>
        /// <param name="noteId">Unique identifier of the order note.</param>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateOrderNoteUrl(string noteId, string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/notes/{noteId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "noteId", noteId);
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteOrderNote
        /// </summary>
        /// <param name="noteId">Unique identifier of the order note to delete.</param>
        /// <param name="orderId">Unique identifier of the order associated with the note.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteOrderNoteUrl(string noteId, string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/notes/{noteId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "noteId", noteId);
			mozuUrl.FormatUrl( "orderId", orderId);
			return mozuUrl;
		}

		
	}
}

