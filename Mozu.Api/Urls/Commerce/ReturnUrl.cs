
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce
{
	public partial class ReturnUrl 
	{

		/// <summary>
        /// Get Resource Url for GetReturns
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/returns/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetReturn
        /// </summary>
        /// <param name="returnId">Returns the properties of the return specified in the request as well as system-supplied information.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetReturnUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAvailableReturnActions
        /// </summary>
        /// <param name="returnId">Retrieves a list of the actions available to perform for the specified return based on its current state.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailableReturnActionsUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPayments
        /// </summary>
        /// <param name="returnId">Returns the details of the refund payment associated with the return specified in the request.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPaymentsUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/payments";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetPayment
        /// </summary>
        /// <param name="paymentId">Unique identifier of the return payment to retrieve.</param>
        /// <param name="returnId">Unique identifier of the return associated with the payment.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetPaymentUrl(string paymentId, string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/payments/{paymentId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAvailablePaymentActionsForReturn
        /// </summary>
        /// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
        /// <param name="returnId">Unique identifier of the return associated with the payment.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAvailablePaymentActionsForReturnUrl(string paymentId, string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/payments/{paymentId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateReturn
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateReturnUrl()
		{
			var url = "/api/commerce/returns/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for PerformPaymentActionForReturn
        /// </summary>
        /// <param name="paymentId">Unique identifier of the return payment to update.</param>
        /// <param name="returnId">Unique identifier of the return associated with the refund payment.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl PerformPaymentActionForReturnUrl(string paymentId, string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/payments/{paymentId}/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "paymentId", paymentId);
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for CreatePaymentActionForReturn
        /// </summary>
        /// <param name="returnId">Unique identifier of the return associated with the payment action.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreatePaymentActionForReturnUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}/payments/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for PerformReturnActions
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl PerformReturnActionsUrl()
		{
			var url = "/api/commerce/returns/actions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateReturn
        /// </summary>
        /// <param name="returnId">Unique identifier of the return.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateReturnUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteReturn
        /// </summary>
        /// <param name="returnId">Unique identifier of the return to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteReturnUrl(string returnId)
		{
			var url = "/api/commerce/returns/{returnId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "returnId", returnId);
			return mozuUrl;
		}

		
	}
}

