
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

namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	List of returns and the details of each return in the list.
		///
		public class ReturnCollection
		{
			public long PageCount { get; set; }

			public int PageSize { get; set; }

			public int StartIndex { get; set; }

			public long TotalCount { get; set; }

			public List<Return> Items { get; set; }

		}

}