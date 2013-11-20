
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

namespace Mozu.Api.Contracts.Customer
{
		///
		///	Paged list of contact information for a specified customer account.
		///
		public class CustomerContactCollection
		{
			///
			///The number of pages returned based on the startIndex and pageSize supplied. Signed 64-bit (8-byte) integer. System-supplied and read-only.
			///
			public long PageCount { get; set; }

			///
			///Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.
			///
			public int PageSize { get; set; }

			///
			///"Used to create paged results from a query. Indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3."
			///
			public int StartIndex { get; set; }

			///
			///The number of the resource entity items listed in the query collection. Signed 64-bit (8-byte) integer. System-supplied and read-only.
			///
			public long TotalCount { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<CustomerContact> Items { get; set; }

		}

}