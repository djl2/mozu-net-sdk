
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


namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PaymentResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public PaymentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var paymentCollection = payment.GetPayments( orderId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection GetPayments(string orderId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetPaymentsClient( orderId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="paymentId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var payment = payment.GetPayment( orderId,  paymentId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.Payment GetPayment(string orderId, string paymentId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetPaymentClient( orderId,  paymentId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="paymentId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var string = payment.GetAvailablePaymentActions( orderId,  paymentId, authTicket);
		/// </code>
		/// </example>
		public virtual List<string> GetAvailablePaymentActions(string orderId, string paymentId, AuthTicket authTicket= null)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.GetAvailablePaymentActionsClient( orderId,  paymentId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="paymentId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var order = payment.PerformPaymentAction( action,  orderId,  paymentId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order PerformPaymentAction(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, string paymentId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.PerformPaymentActionClient( action,  orderId,  paymentId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var payment = new Payment();
		///   var order = payment.CreatePaymentAction( action,  orderId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreatePaymentAction(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string orderId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PaymentClient.CreatePaymentActionClient( action,  orderId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

						
	}

}


