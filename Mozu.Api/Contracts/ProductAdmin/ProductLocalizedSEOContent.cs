
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
		///	The localized product search engine optimized content in the language specified by the LocaleCode.
		///
		public class ProductLocalizedSEOContent
		{
			///
			///"Language used for the entity. Currently, only ""en-US"" is supported."
			///
			public string LocaleCode { get; set; }

			///
			///The description of the metatag used for the product SEO content set to the locale code language. The metadata description is used to manage information internally.
			///
			public string MetaTagDescription { get; set; }

			///
			///The metatag keywords for the product SEO content set in the locale code language. The metatag keywords are used to manage information internally.
			///
			public string MetaTagKeywords { get; set; }

			///
			///The metatag title for the product SEO content set in the locale code language. The metatag title is used to manage information internally.
			///
			public string MetaTagTitle { get; set; }

			///
			///The search engine optimized human-readable portion of the URL in the language of the product's locale code.
			///
			public string SeofriendlyUrl { get; set; }

			///
			///Customizes the HTML title tag within the header section of the product details page for the specified product.
			///
			public string TitleTagTitle { get; set; }

		}

}