
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
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Details of an attribute used to describe individual aspects of a product.
		///
		public class Attribute
		{
			///
			///The administrative name of the product attribute as it appears in Mozu Admin.
			///
			public string AdminName { get; set; }

			///
			///Merchant-defined identifier of the product attribute used to generate the attribute's fully qualified name.
			///
			public string AttributeCode { get; set; }

			///
			///Generated sequence that increments for each attribute and data type combination created. This value is system-supplied and read-only.
			///
			public int? AttributeDataTypeSequence { get; set; }

			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///Generated sequence that increments for each product attribute created. This value is system-supplied and read-only.
			///
			public int? AttributeSequence { get; set; }

			///
			///The data type of the product attribute, which is a Bool, DateTime, Number, or String. The attribute's data type cannot be changed.
			///
			public string DataType { get; set; }

			///
			///The storefront interface input type for the product attribute, which is a Date, DateTime, List, TextArea, TextBox, or YesNo. The attribute's input type cannot be changed.
			///
			public string InputType { get; set; }

			///
			///If true, the product attribute is an add-on configuration made by the shopper that does not represent a product variation, such as a monogram.
			///
			public bool? IsExtra { get; set; }

			///
			///If true, the product attribute is a merchant- or shopper-configurable option, such as size or color, that represents a product variation.
			///
			public bool? IsOption { get; set; }

			///
			///If true, the product attribute describes aspects of the product that do not represent an option configurable by the shopper, such as screen resolution or brand.
			///
			public bool? IsProperty { get; set; }

			public int? MasterCatalogId { get; set; }

			///
			///If applicable, the registered namespace associated with the product attribute, used to generate the fully qualified name. If no namespace is defined, the namespace associated with the tenant is automatically assigned.
			///
			public string Namespace { get; set; }

			///
			///The type of value associated with the product attribute, which is ShopperEntered (the shopper selects or enters an attribute value during checkout), Predefined (the merchant sets the attribute value from a list during product attribute definition), or AdminEntered (the merchant selects or enters a value during product definition). The attribute value type cannot be changed.
			///
			public string ValueType { get; set; }

			///
			///List of key-value pairs that store metadata associated with the product attribute.
			///
			public List<AttributeMetadataItem> AttributeMetadata { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public AttributeLocalizedContent Content { get; set; }

			///
			///Properties of the validation of a product attribute, which contains rules that dictate what values are valid entries for product attributes.
			///
			public AttributeValidation Validation { get; set; }

			///
			///Array list of the defined vocabulary values for the specified product attribute. For example, for a Color attribute, vocabulary values might include black, white, and purple.
			///
			public List<AttributeVocabularyValue> VocabularyValues { get; set; }

		}

}