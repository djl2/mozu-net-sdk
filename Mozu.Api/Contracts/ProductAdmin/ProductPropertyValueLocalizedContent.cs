
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
		///	Content of the product property value in the language defined for the locale code.
		///
		public class ProductPropertyValueLocalizedContent
		{
			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///The string value of the product property set in the language specified the locale code.
			///
			public string StringValue { get; set; }

		}

}