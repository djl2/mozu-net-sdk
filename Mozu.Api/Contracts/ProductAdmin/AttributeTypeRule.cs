
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
		///	Properties of the attribute type rule.
		///
		public class AttributeTypeRule
		{
			///
			///The data type of the attribute. There are four valid data types: "Bool", "DateTime", "Number", "String"
			///
			public string AttributeDataType { get; set; }

			///
			///An attribute's data type would be either "NotSpecified", "Textbox", "Textarea", "Date", "DateTime", "Dropdown", "Listbox", "Radio", "Currency", or "Checkbox" and will be a valid value defined in the type rules resource.
			///
			public string AttributeInputType { get; set; }

			///
			///Describes how an attribute will be used. Valid types are "Extra", "Option", and "Property"
			///
			public string AttributeUsageType { get; set; }

			///
			///An attribute value type is either predefined vocabulary by the admin during product attribute set up or it can be "AdminEntered" or "ShopperEntered". The difference between predefined values versus manually entered values is such that the first choice is a set of options to choose from. AdminEntered and ShopperEntered are values that are entered rather than system-supplied and are not stored in the database, but captured during a live commerce operations such as during an order.
			///
			public string AttributeValueType { get; set; }

		}

}