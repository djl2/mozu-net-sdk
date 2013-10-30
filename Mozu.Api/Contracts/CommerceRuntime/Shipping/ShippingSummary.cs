using System;

namespace Mozu.Api.Contracts.CommerceRuntime.Shipping
{
	public class ShippingSummary : Version
	{
		public string Carrier { get; set; }
		public string CountryCode { get; set; }
		public string PostalCode { get; set; }
		public string ShippingType { get; set; }
	}

}