
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

namespace Mozu.Api.Contracts.Content
{
		///
		///	Collection of content folders in a document list.
		///
		public class FolderCollection
		{
			///
			///The number of pages returned based on the startIndex and pageSize values specified. This value is system-supplied and read-only.
			///
			public long PageCount { get; set; }

			///
			///Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.
			///
			public long PageSize { get; set; }

			///
			///Indicates the zero-based offset in the complete result set where the returned entities begin, when creating paged results from a query. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.
			///
			public long StartIndex { get; set; }

			///
			///The number of results listed in the query collection, represented by a signed 64-bit (8-byte) integer. This value is system-supplied and read-only.
			///
			public long TotalCount { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<Folder> Items { get; set; }

		}

}