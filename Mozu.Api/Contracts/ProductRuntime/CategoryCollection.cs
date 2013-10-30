
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

namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	The container for a non-paged list of related site-specific product category properties.
		///
		public class CategoryCollection
		{
			///
			///The number of results listed in the query collection, represented by a signed 64-bit (8-byte) integer. This value is system-supplied and read-only.
			///
			public int TotalCount { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<Category> Items { get; set; }

		}

}