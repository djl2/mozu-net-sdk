
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	The price of the product in the specified currency code (USD). This price can either be the sale price or the price for which the merchant intends to sell the product.
		///
		public class ProductPrice
		{
			public decimal? CatalogListPrice { get; set; }

			public decimal? CatalogSalePrice { get; set; }

			public decimal? Msrp { get; set; }

			///
			///The price the merchant intends to charge for the product.
			///
			public decimal? Price { get; set; }

			public string PriceType { get; set; }

			///
			///The sale price defined for the product.
			///
			public decimal? SalePrice { get; set; }

			public string SalePriceType { get; set; }

			///
			///The discount applied to the product price.
			///
			public AppliedDiscount Discount { get; set; }

		}

}