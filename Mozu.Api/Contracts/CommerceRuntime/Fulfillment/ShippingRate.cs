
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

namespace Mozu.Api.Contracts.CommerceRuntime.Fulfillment
{
		///
		///	Properties of an estimated shipping rate for a shipment.
		///
		public class ShippingRate
		{
			///
			///3-letter ISO 4217 standard global currency code. Currently, only "USD" (US Dollar) is supported.
			///
			public string CurrencyCode { get; set; }

			///
			///If true, the estimated shipping rate is valid.
			///
			public bool? IsValid { get; set; }

			///
			///Array list of validation messages associated with the shipping rate.
			///
			public List<string> Messages { get; set; }

			///
			///The amount the company and the shopper pay for shipping based on the current rate. Depending on any company discounts or fees, the price the company pays for shipping may differ from what the shopper pays.
			///
			public decimal? Price { get; set; }

			///
			///The code that identifies the service type shipping method, such as FED_EX_INTERNATIONAL.
			///
			public string ShippingMethodCode { get; set; }

			///
			///The name of the shipping method associated with the estimated rate, such as "UPS Ground".
			///
			public string ShippingMethodName { get; set; }

		}

}