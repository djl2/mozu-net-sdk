
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Properties of the active product inventory levels for a specific location.
		///
		public class LocationInventory
		{
			///
			///User-defined code that uniquely identifies the location.
			///
			public string LocationCode { get; set; }

			///
			///The current level of active product stock available at the specified location.
			///
			public int? StockAvailable { get; set; }

		}

}