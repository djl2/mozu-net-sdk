
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
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		public class ProductType
		{
			public int? Id { get; set; }

			public bool IsBaseProductType { get; set; }

			public int? MasterCatalogId { get; set; }

			public string Name { get; set; }

			public int? ProductCount { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public List<AttributeInProductType> Extras { get; set; }

			public List<AttributeInProductType> Options { get; set; }

			public List<AttributeInProductType> Properties { get; set; }

		}

}