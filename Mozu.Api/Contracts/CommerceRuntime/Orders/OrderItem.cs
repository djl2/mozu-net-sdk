
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
using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.CommerceRuntime.Products;
using Mozu.Api.Contracts.CommerceRuntime.Discounts;
using Mozu.Api.Contracts.CommerceRuntime.Commerce;

namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	The details associated with a specific item in an order.
		///
		public class OrderItem
		{
			///
			///The subtotal of the order item including any applied discount calculations.
			///
			public decimal? DiscountedTotal { get; set; }

			///
			///Estimated amount of discounts applied to the item in the order, which is system-supplied and read-only.
			///
			public decimal? DiscountTotal { get; set; }

			///
			///Represents the total price of the order item extended to the shopper. This begins with the Unit Price, then uses any of the following prices if they are defined, in the following order: Override Amount, Sale Amount, List Amount.
			///
			public decimal? ExtendedTotal { get; set; }

			///
			///The total sum of all fees incurred for an item in an order.
			///
			public decimal? FeeTotal { get; set; }

			///
			///Code that identifies the location used to fulfill this order item, whether via in-store pickup or direct shipment.
			///
			public string FulfillmentLocationCode { get; set; }

			///
			///The method used to fulfill the item in the order, which is "PickUp" or "Ship".
			///
			public string FulfillmentMethod { get; set; }

			///
			///Unique identifier of a specific item in an order.
			///
			public string Id { get; set; }

			///
			///If true, the item in the order can be purchased or fulfilled at regular intervals such as a monthly billing cycle or a digital or physical subscription. This property is reserved for future functionality and is system-supplied and read only.
			///
			public bool? IsRecurring { get; set; }

			///
			///If true, the entity is subject to tax based on the relevant tax rate.
			///
			public bool? IsTaxable { get; set; }

			///
			///The total amount of tax that applied to an item in an order.
			///
			public decimal? ItemTaxTotal { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///The unique identifier of the item when it was applied to a cart, prior to checkout, when the cart became an order.
			///
			public string OriginalCartItemId { get; set; }

			///
			///The quantity of a specific item in an order.
			///
			public int Quantity { get; set; }

			///
			///The total amount of sales tax incurred for shipping charges associated with this item in a cart.
			///
			public decimal? ShippingTaxTotal { get; set; }

			///
			///Total amount of shipping fees associated with the specified item in the order.
			///
			public decimal? ShippingTotal { get; set; }

			///
			///Amount of the item in the order without sales tax, shipping costs, and other fees.
			///
			public decimal? Subtotal { get; set; }

			///
			///The amount of the item in the order that is subject to tax. This amount typically represents the order item subtotal before applied discounts.
			///
			public decimal? TaxableTotal { get; set; }

			///
			///The total monetary sum of a specific item in an order.
			///
			public decimal? Total { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The product properties of an item in an order.
			///
			public Product Product { get; set; }

			public AppliedProductDiscount ProductDiscount { get; set; }

			///
			///List of product discounts that apply to the item in the order.
			///
			public List<AppliedProductDiscount> ProductDiscounts { get; set; }

			///
			///List of shipping discounts that apply to the item in the order.
			///
			public List<ShippingDiscount> ShippingDiscounts { get; set; }

			///
			///Properties of the unit price associated with the order item.
			///
			public CommerceUnitPrice UnitPrice { get; set; }

		}

}