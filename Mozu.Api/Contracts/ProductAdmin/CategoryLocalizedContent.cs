
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

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The container for category properties that are shown in the language specified by the locale code.
		///
		public class CategoryLocalizedContent
		{
			///
			///Description of the product category in the language specified by the locale code.
			///
			public string Description { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///Description defined for the product category metadata, used to manage internal product information, in the language specified by the locale code.
			///
			public string MetaTagDescription { get; set; }

			///
			///Keywords defined for the product category metadata, used to manage internal product information, in the language specified by the locale code.
			///
			public string MetaTagKeywords { get; set; }

			///
			///Title defined for the product category metadata, used to manage internal product information, in the language specified by the locale code.
			///
			public string MetaTagTitle { get; set; }

			///
			///The name of the product category in the language specified by the locale code.
			///
			public string Name { get; set; }

			///
			///Title that appears on new product category pages, in the language specified by the locale code.
			///
			public string PageTitle { get; set; }

			///
			///Human-readable identifier to assign to the category to generate user-friendly URLs.
			///
			public string Slug { get; set; }

			///
			///Array of localized product category images in the language specified by the LocaleCode.
			///
			public List<CategoryLocalizedImage> CategoryImages { get; set; }

		}

}