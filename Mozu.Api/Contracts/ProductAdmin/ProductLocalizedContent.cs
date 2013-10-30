
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

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The localized product content in the language specified by the LocaleCode.
		///
		public class ProductLocalizedContent
		{
			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///More detailed or full product description typically used for a product details page.
			///
			public string ProductFullDescription { get; set; }

			///
			///The descriptive brief product name.
			///
			public string ProductName { get; set; }

			///
			///Brief description of the product typically used when the product is displayed in a list or in search results.
			///
			public string ProductShortDescription { get; set; }

			///
			///List of product images associated with a product.
			///
			public List<ProductLocalizedImage> ProductImages { get; set; }

		}

}