
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

namespace Mozu.Api.Contracts.Reference
{
		///
		///	The paged collection of all units of measure that the system currently supports.
		///
		public class UnitOfMeasureCollection
		{
			///
			///The number of the resource entity items listed in the query collection. Signed 64-bit (8-byte) integer. System-supplied and read-only.
			///
			public long TotalCount { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<UnitOfMeasure> Items { get; set; }

		}

}