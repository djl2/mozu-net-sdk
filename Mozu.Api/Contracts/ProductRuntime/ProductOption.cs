
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
		///
		///	Represents configurable and stand-alone options that a shopper can choose when ordering a product. Configurable options apply to a product, for example, a shopper chooses a T-shirtâ€™s color and size. A stand-alone option is independent of a product itself but can be added to a product when ordering it. For example, a shopper may choose to add a personalized monogram.
		///
		public class ProductOption
		{
			///
			///"The fully qualified name of the attribute, which is a user defined attribute identifier."
			///
			public string AttributeFQN { get; set; }

			///
			///If true, the product attribute or option has multiple values.
			///
			public bool? IsMultiValue { get; set; }

			///
			///If true, the entity is required for the request to return a valid response.
			///
			public bool? IsRequired { get; set; }

			///
			///Details of the product option attribute.
			///
			public AttributeDetail AttributeDetail { get; set; }

			///
			///List of possible values for a product option attribute.
			///
			public List<ProductOptionValue> Values { get; set; }

		}

}