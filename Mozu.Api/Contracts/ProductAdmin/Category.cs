
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		public class Category
		{
			public int? CatalogId { get; set; }

			public int? ChildCount { get; set; }

			public int? Id { get; set; }

			public bool? IsDisplayed { get; set; }

			public int? ParentCategoryId { get; set; }

			public int? ProductCount { get; set; }

			public int? Sequence { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public CategoryLocalizedContent Content { get; set; }

		}

}