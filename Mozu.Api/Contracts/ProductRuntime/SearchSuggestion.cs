
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

namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	Suggest product search terms to a customer based on defined queries.
		///
		public class SearchSuggestion
		{
			///
			///The query term entered by the shopper.
			///
			public string Query { get; set; }

			///
			///The term suggestions to return based on the specified query value.
			///
			public List<string> Suggestions { get; set; }

		}

}