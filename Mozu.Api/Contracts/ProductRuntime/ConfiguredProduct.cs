
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
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
		///	Properties of a created product selection.
		///
		public class ConfiguredProduct
		{
			public List<string> FulfillmentTypesSupported { get; set; }

			public string MfgPartNumber { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			public string Upc { get; set; }

			///
			///Merchant-created code associated with a specific product variation. Variation product codes maintain an association with the base product code.
			///
			public string VariationProductCode { get; set; }

			///
			///List of shipping discounts that can be applied to the configured product.
			///
			public List<Discount> AvailableShippingDiscounts { get; set; }

			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///Dimensions of the packaged product.
			///
			public PackageMeasurements Measurements { get; set; }

			///
			///The list of options set up in product admin.
			///
			public List<ProductOption> Options { get; set; }

			///
			///Price that the merchant intends to sell the product which is not necessarily the list price. This is the price the merchant intends to sell the product if no sale price is present.
			///
			public ProductPrice Price { get; set; }

			///
			///For products with options that vary the cost of the product, the range between lowest and highest possible price of the product based on the current selection of options.
			///
			public ProductPriceRange PriceRange { get; set; }

			///
			///The current state of the configured product determines whether or not the product is eligible for purchase. Products with options are only purchasable if the shopper has selected all required options. If the product is not ready for purchase, a message lists missing options that are required.
			///
			public ProductPurchasableState PurchasableState { get; set; }

		}

}