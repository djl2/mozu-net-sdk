
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
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the Payments subresource to manage payment transactions for orders. Each transaction performed for an order represents an individual payment. For example, if an order totals $75.00 but the shopper has a $50.00 gift certificate, both the gift certificate transaction and the credit card transaction for the remaining $25.00 are recorded as payments for the order.
	/// </summary>
	public partial class PaymentClient 	{
		
		/// <summary>
		/// Retrieves information about all payment transactions submitted for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayments( orderId, authTicket);
		///   var paymentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> GetPaymentsClient(string orderId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.GetPaymentsUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves information about a specific payment transaction submitted for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the payment transaction.</param>
		/// <param name="paymentId">Unique identifier of the payment transaction submitted for the order.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayment( orderId,  paymentId, authTicket);
		///   var paymentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> GetPaymentClient(string orderId, string paymentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.GetPaymentUrl(orderId, paymentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the list of all available payment actions dependent on the order payment status by specifying the order ID.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the payment.</param>
		/// <param name="paymentId">Unique identifer of the payment for which to retrieve available actions.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailablePaymentActions( orderId,  paymentId, authTicket);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailablePaymentActionsClient(string orderId, string paymentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.GetAvailablePaymentActionsUrl(orderId, paymentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Performs the specified action for an individual order payment transaction.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the payment.</param>
		/// <param name="paymentId">Unique identifer of the payment for which to perform the action.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action">The action to perform for the payment. Possible values are AuthAndCapture, AuthorizePayment, CapturePayment, VoidPayment, CreditPayment, RequestCheck, ApplyCheck, DeclineCheck.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformPaymentAction( action,  orderId,  paymentId, authTicket);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformPaymentActionClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string paymentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.PerformPaymentActionUrl(orderId, paymentId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Creates a new payment transaction for the specified order and performs the specified action.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to apply the payment.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action">To action to perform for the newly created payment. Possible values are AuthAndCapture, AuthorizePayment, CapturePayment, VoidPayment, CreditPayment, RequestCheck, ApplyCheck, DeclineCheck.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePaymentAction( action,  orderId, authTicket);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreatePaymentActionClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PaymentUrl.CreatePaymentActionUrl(orderId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}


	}

}


