
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
		///	Collection of payment transactions associated with an order.
		///
		public class PaymentCollection
		{
			///
			///The maximum number of items that can appear in this collection.
			///
			public int Capacity { get; set; }

			///
			///The number of results listed in the query collection, represented by a signed 64-bit (8-byte) integer. This value is system-supplied and read-only.
			///
			public int Count { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public Payment Item { get; set; }

		}

}