
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
		///	Content associated with a product definition that can be localized.
		///
		public class ProductContent
		{
			///
			///Description defined for the metadata used to internally manage information about the product.
			///
			public string MetaTagDescription { get; set; }

			///
			///Keywords defined for the metadata used to internally manage information about the product.
			///
			public string MetaTagKeywords { get; set; }

			///
			///Title defined for the metadata used to internally manage information about the product.
			///
			public string MetaTagTitle { get; set; }

			///
			///Full description of the product, which typically appears on the product details page.
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
			///Product URL defined for search engine optimization.
			///
			public string SeofriendlyUrl { get; set; }

			///
			///List of image files associated with the product.
			///
			public List<ProductImage> ProductImages { get; set; }

		}

}