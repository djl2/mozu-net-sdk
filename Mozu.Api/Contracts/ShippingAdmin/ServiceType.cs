
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.ShippingAdmin
{
		///
		///	Properties of the service type, or shipping method, for a specific shipping carrier.
		///
		public class ServiceType
		{
			///
			///The service type code supplied by the carrier. Service type codes include a prefix that indicates the carrier name. For example: FEDEX_INTERNATIONAL_STANDARD.
			///
			public string Code { get; set; }

			///
			///If true, the shipping service type is available for use. Certain service types are locale-dependent.
			///
			public bool? IsActive { get; set; }

			///
			///If true, the shipping service type is available for international parcel. If false, the shipping service type is only available for domestic parcel.
			///
			public bool? IsInternational { get; set; }

			///
			///The numeric value that denotes the place this entity occupies in the order of the entity list.
			///
			public int? Sequence { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public ServiceTypeLocalizedContent Content { get; set; }

		}

}