
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.PricingRuntime
{
		///
		///	The tax properties associated with the order.
		///
		public class TaxContext
		{
			///
			///Unique identifier of the customer.
			///
			public string CustomerId { get; set; }

			///
			///Unique identifier of the tax context.
			///
			public string TaxContextId { get; set; }

			///
			///If the order is exempt from sales tax, the unique identifier of the tax exempt entity.
			///
			public string TaxExemptId { get; set; }

			///
			///The address to which the order ships.
			///
			public Address DestinationAddress { get; set; }

			///
			///The address from which the order ships.
			///
			public Address OriginAddress { get; set; }

		}

}