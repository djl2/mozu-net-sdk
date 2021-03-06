
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

namespace Mozu.Api.Contracts.Reference
{
		///
		///	Describes the structure of postal addresses based on the country specified. Because addresses vary from country to country, this schema allows a flexible storage structure.
		///
		public class AddressSchema
		{
			///
			///The 2-letter geographic code representing the country for the physical or mailing address. Currently limited to the US.
			///
			public string CountryCode { get; set; }

			///
			///The label associated with this country.
			///
			public string CountryLabel { get; set; }

			///
			///The unique identifier of this postal address schema.
			///
			public int Id { get; set; }

			///
			///The fields to display for postal addresses associated with this country.
			///
			public List<Field> Fields { get; set; }

		}

}