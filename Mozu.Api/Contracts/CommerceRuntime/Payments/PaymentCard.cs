
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.CommerceRuntime.Payments
{
		///
		///	Properties of a credit card used to submit payment for an order.
		///
		public class PaymentCard
		{
			///
			///The masked credit card number part returned from the payment gateway.
			///
			public string CardNumberPartOrMask { get; set; }

			///
			///The two-digit month the credit card expires.
			///
			public int ExpireMonth { get; set; }

			///
			///The four-digit year the credit card expires.
			///
			public int ExpireYear { get; set; }

			///
			///If true, the credit card information is saved to the customer account for future use.
			///
			public bool IsCardInfoSaved { get; set; }

			///
			///If true, the credit card is used for a recurring order payment.
			///
			public bool? IsUsedRecurring { get; set; }

			///
			///The name printed on the credit card.
			///
			public string NameOnCard { get; set; }

			///
			///The type of credit card, such as Visa or Amex.
			///
			public string PaymentOrCardType { get; set; }

			///
			///Unique identifier of the credit card from the payment service.
			///
			public string PaymentServiceCardId { get; set; }

		}

}