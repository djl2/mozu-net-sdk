
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.Core.Extensible
{
		///
		///	The property type of the attribute set content. Includes description, locale code, and name.
		///
		public class AttributeSetLocalizedContent
		{
			///
			///Description of the attribute set, in the language specified by the locale code.
			///
			public string Description { get; set; }

			///
			///Language used for the entity. Currently, only "en-US" is supported.
			///
			public string LocaleCode { get; set; }

			///
			///Name of the attribute set, in the language specified by the locale code.
			///
			public string Name { get; set; }

		}

}