
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.Customer
{
		///
		///	The order summary includes the date of the most recent order, a list of the number of orders made, and the total monetary sum of all orders including cancellations and refunds.
		///
		public class OrderSummary
		{
			///
			///The most recent order date made by the specified customer account. System-supplied and read-only.
			///
			public DateTime? LastOrderDate { get; set; }

			///
			///The number of orders.
			///
			public int OrderCount { get; set; }

			///
			///The total monetary sum of the order, including items, sales tax, shipping fees, and other fees.
			///
			public CurrencyAmount TotalOrderAmount { get; set; }

		}

}