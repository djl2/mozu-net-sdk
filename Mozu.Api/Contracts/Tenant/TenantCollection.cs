
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

namespace Mozu.Api.Contracts.Tenant
{
		public class TenantCollection
		{
			public long PageCount { get; set; }

			public int PageSize { get; set; }

			public int StartIndex { get; set; }

			public long TotalCount { get; set; }

			public List<Tenant> Items { get; set; }

		}

}