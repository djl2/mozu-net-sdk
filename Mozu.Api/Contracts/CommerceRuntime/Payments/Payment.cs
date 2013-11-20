
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
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.CommerceRuntime.Payments
{
		///
		///	Properties of a payment transaction submitted for an order.
		///
		public class Payment
		{
			///
			///The total monetary amount collected in this payment transaction for the order.
			///
			public decimal AmountCollected { get; set; }

			///
			///If the payment transaction is a shopper credit, the total monetary amount credited in this payment transaction for the order.
			///
			public decimal AmountCredited { get; set; }

			///
			///The actions a user can perform for a payment at this time.
			///
			public List<string> AvailableActions { get; set; }

			///
			///Unique identifier of the payment transaction.
			///
			public string Id { get; set; }

			///
			///If true, the payment transaction occurs at regular intervals such as a monthly billing cycle or a digital or physical subscription.
			///
			public bool IsRecurring { get; set; }

			///
			///Unique identifier of the order associated with the payment.
			///
			public string OrderId { get; set; }

			///
			///The transaction ID supplied by the payment service to associate with this order payment.
			///
			public string PaymentServiceTransactionId { get; set; }

			///
			///The type of payment transaction performed, either check or credit card. Paypal and additional payment types will be supported in a future release.
			///
			public string PaymentType { get; set; }

			///
			///Current status of the payment transaction for the order.
			///
			public string Status { get; set; }

			///
			///Identifier and datetime stamp information recorded when creating or updating a resource entity. System-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The billing information associates with this payment.
			///
			public BillingInfo BillingInfo { get; set; }

			///
			///Container for the interactions associated with the payment, which includes details for each action performed for the payment.
			///
			public List<PaymentInteraction> Interactions { get; set; }

		}

}