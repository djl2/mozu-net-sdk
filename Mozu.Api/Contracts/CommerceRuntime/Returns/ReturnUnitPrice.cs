using System;

namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	Properties of the unit price of a returned item.
		///
		public class ReturnUnitPrice
		{
			///
			///The sales tax amount associated with the returned item.
			///
			public decimal? ItemTaxAmount { get; set; }

			///
			///The total amount of shipping feed associated with the returned item.
			///
			public decimal? ShippingAmount { get; set; }

			///
			///The amount of sales tax incurred on shipping fees for a returned item.
			///
			public decimal? ShippingTaxAmount { get; set; }

			///
			///The amount of the returned item that is subject to tax. This amount typically represents the order item subtotal before applied discounts.
			///
			public decimal? TaxableAmount { get; set; }

		}

}