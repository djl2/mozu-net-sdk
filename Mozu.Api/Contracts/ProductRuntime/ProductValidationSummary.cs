
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
		public class ProductValidationSummary
		{
			public bool IsTaxable { get; set; }

			public string ProductCode { get; set; }

			public string ProductName { get; set; }

			public string ProductShortDescription { get; set; }

			public string VariationProductCode { get; set; }

			public List<Category> Categories { get; set; }

			public ProductImage Image { get; set; }

			public ProductInventoryInfo InventoryInfo { get; set; }

			public PackageMeasurements Measurements { get; set; }

			public ProductPrice Price { get; set; }

			public List<ProductProperty> Properties { get; set; }

			public ProductPurchasableState PurchasableState { get; set; }

		}

}