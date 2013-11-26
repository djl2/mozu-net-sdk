
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
using Mozu.Api.Contracts.CommerceRuntime.Products;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;
using Mozu.Api.Contracts.CommerceRuntime.Commerce;

namespace Mozu.Api.Contracts.CommerceRuntime.Carts
{
		public class CartItem
		{
			public decimal? DiscountedTotal { get; set; }

			public decimal? DiscountTotal { get; set; }

			public decimal? ExtendedTotal { get; set; }

			public decimal? FeeTotal { get; set; }

			public string FulfillmentLocationCode { get; set; }

			public string FulfillmentMethod { get; set; }

			public string Id { get; set; }

			public bool? IsRecurring { get; set; }

			public bool? IsTaxable { get; set; }

			public decimal? ItemTaxTotal { get; set; }

			public string LocaleCode { get; set; }

			public int Quantity { get; set; }

			public decimal? ShippingTaxTotal { get; set; }

			public decimal? ShippingTotal { get; set; }

			public decimal? Subtotal { get; set; }

			public decimal? TaxableTotal { get; set; }

			public decimal? Total { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public Product Product { get; set; }

			public List<AppliedProductDiscount> ProductDiscounts { get; set; }

			public List<ShippingDiscount> ShippingDiscounts { get; set; }

			public CommerceUnitPrice UnitPrice { get; set; }

		}

}