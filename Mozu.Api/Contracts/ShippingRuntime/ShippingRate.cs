
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

namespace Mozu.Api.Contracts.ShippingRuntime
{
		public class ShippingRate
		{
			public decimal? Amount { get; set; }

			public string Code { get; set; }

			public ShippingRateLocalizedContent Content { get; set; }

			public List<CustomAttribute> CustomAttributes { get; set; }

			public List<ShippingRateValidationMessage> Messages { get; set; }

			public List<ShippingItemRate> ShippingItemRates { get; set; }

		}

}