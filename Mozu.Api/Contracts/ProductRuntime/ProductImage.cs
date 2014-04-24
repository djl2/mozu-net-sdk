
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
		///	Properties of an image defined for a product.
		///
		public class ProductImage
		{
			///
			///Descriptive text associated with the image or video that appears on the storefront.
			///
			public string AltText { get; set; }

			public string CmsId { get; set; }

			///
			///Image title that appears on the storefront.
			///
			public string ImageLabel { get; set; }

			///
			///URL of the product image.
			///
			public string ImageUrl { get; set; }

			///
			///Type of media specification required to successfully render the product image, video, or other content.
			///
			public string MediaType { get; set; }

			///
			///The numeric value that denotes the place this entity occupies in the order of the entity list.
			///
			public int? Sequence { get; set; }

			///
			///The file link or URL of the product video.
			///
			public string VideoUrl { get; set; }

		}

}