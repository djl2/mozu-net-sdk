
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

namespace Mozu.Api.Contracts.PricingRuntime
{
		///
		///	Properties of a line item in an order that is subject to tax.
		///
		public class TaxableLineItem
		{
			///
			///Unique identifier of the taxable line item.
			///
			public string Id { get; set; }

			///
			///If true, the line item in the order is subject to tax.
			///
			public bool? IsTaxable { get; set; }

			///
			///The sale price of the line item in the order.
			///
			public decimal LineItemPrice { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			public string ProductName { get; set; }

			///
			///The quantity of the line item in the order.
			///
			public int Quantity { get; set; }

			public string Reason { get; set; }

			///
			///The amount of shipping calculated for a line item in an order.
			///
			public decimal ShippingAmount { get; set; }

			///
			///Properties of the product that represents the line item in the order.
			///
			public List<ProductProperty> ProductProperties { get; set; }

		}

}