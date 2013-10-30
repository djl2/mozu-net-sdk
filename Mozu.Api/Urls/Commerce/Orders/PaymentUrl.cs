
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
	public partial class PaymentUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetPayments
        /// </summary>
        /// <param name="orderId">Unique identifier of the order.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetPaymentsUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/payments/";
			FormatUrl( ref url, "orderId", orderId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetPayment
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the payment transaction.</param>
        /// <param name="paymentId">Unique identifier of the payment transaction submitted for the order.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetPaymentUrl(string orderId, string paymentId)
		{
			var url = "/api/commerce/orders/{orderId}/payments/{paymentId}";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "paymentId", paymentId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetAvailablePaymentActions
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the payment.</param>
        /// <param name="paymentId">Unique identifer of the payment for which to retrieve available actions.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetAvailablePaymentActionsUrl(string orderId, string paymentId)
		{
			var url = "/api/commerce/orders/{orderId}/payments/{paymentId}/actions";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "paymentId", paymentId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for PerformPaymentAction
        /// </summary>
        /// <param name="orderId">Unique identifier of the order associated with the payment.</param>
        /// <param name="paymentId">Unique identifer of the payment for which to perform the action.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string PerformPaymentActionUrl(string orderId, string paymentId)
		{
			var url = "/api/commerce/orders/{orderId}/payments/{paymentId}/actions";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "paymentId", paymentId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for CreatePaymentAction
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for which to apply the payment.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string CreatePaymentActionUrl(string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/payments/actions";
			FormatUrl( ref url, "orderId", orderId);
			return url;
		}

						
	}
}
