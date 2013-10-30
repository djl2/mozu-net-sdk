
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of a defined value for a product extra attribute.
		///
		public class ProductExtraValue
		{
			///
			///The difference between the weight associated with this product extra and the base product. For example, if a product with a monogram weighs an extra 1/4 lb, the DeltaWeight value is "0.25".
			///
			public decimal? DeltaWeight { get; set; }

			///
			///If true, the value for the product extra is selected by default. Shopper entered extras cannot be defaulted.
			///
			public bool? IsDefaulted { get; set; }

			///
			///Properties of a defined value for a product extra attribute.
			///
			public object Value { get; set; }

			///
			///Detail of the product extra attribute vocabulary value.
			///
			public AttributeVocabularyValue AttributeVocabularyValueDetail { get; set; }

			///
			///The difference between the price associated with this product extra and the base product. For example, if a product with a defined monogram extra costs an additional $10, the DeltaPrice value is "10".
			///
			public ProductExtraValueDeltaPrice DeltaPrice { get; set; }

		}

}