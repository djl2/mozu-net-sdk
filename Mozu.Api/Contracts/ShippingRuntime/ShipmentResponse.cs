
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
		public class ShipmentResponse
		{
			public bool IsSuccessful { get; set; }

			public string TrackingNumber { get; set; }

			public List<CustomAttribute> CustomAttributes { get; set; }

			public List<Notification> Messages { get; set; }

			public List<PackageResponse> PackageResponses { get; set; }

			public Money ShippingTotal { get; set; }

		}

}