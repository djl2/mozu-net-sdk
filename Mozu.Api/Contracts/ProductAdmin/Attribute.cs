
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
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Details of the property such as its name and description, whether it is a configurable option, and how many products have this attribute. A product detail that a merchant can define to add to the product base type. Define details, such as specifications, to describe products. Create attributes to share across several or all products in a store or stores such as price, size, weight, color, and brand. Some attributes will apply to a specific type of product or a single product, for example, screen resolution or storage capacity. Create attributes separately from products to share common attributes across products.
		///
		public class Attribute
		{
			///
			///The name of the product associated with this attribute as it appears in the Product Admin.
			///
			public string AdminName { get; set; }

			///
			///Unique identifier of the attribute. Must be unique within a namespace and cannot be changed once referenced by productTypes. This value will be generated to match the attribute sequence if it is not provided during creation.
			///
			public string AttributeCode { get; set; }

			///
			///Unique sequence for each attribute and data type combination created. System-supplied and read-only.
			///
			public int? AttributeDataTypeSequence { get; set; }

			///
			///"The fully qualified name of the attribute, which is a user defined attribute identifier."
			///
			public string AttributeFQN { get; set; }

			///
			///Indicates the order position of the attribute.
			///
			public int? AttributeSequence { get; set; }

			///
			///The data type of the attribute. There are four valid data types: "Bool", "DateTime", "Number", "String"
			///
			public string DataType { get; set; }

			///
			///The storefront interface input type for this attribute such as a radio button or drop-down menu selection.
			///
			public string InputType { get; set; }

			///
			///If true, this entity is marked as an optional choice.
			///
			public bool? IsExtra { get; set; }

			///
			///If true, the entity is available as an option. If false, the entity is not available as an option.
			///
			public bool? IsOption { get; set; }

			///
			///If true, the entity is an available property.
			///
			public bool? IsProperty { get; set; }

			public int? MasterCatalogId { get; set; }

			///
			///Registered namespace associated with this attribute. If no namespace was entered when the attribute was created, the tenant namespace is used.
			///
			public string Namespace { get; set; }

			///
			///An attribute value type is either predefined vocabulary by the admin during product attribute set up or it can be "AdminEntered" or "ShopperEntered". The difference between predefined values versus manually entered values is such that the first choice is a set of options to choose from. AdminEntered and ShopperEntered are values that are entered rather than system-supplied and are not stored in the database, but captured during a live commerce operations such as during an order.
			///
			public string ValueType { get; set; }

			///
			///List of metadata associated with the attribute.
			///
			public List<AttributeMetadataItem> AttributeMetadata { get; set; }

			///
			///Identifier and datetime stamp information recorded when creating or updating a resource entity. System-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public AttributeLocalizedContent Content { get; set; }

			///
			///Validates the attribute configured for the product in the storefront against the attribute configured in product admin.
			///
			public AttributeValidation Validation { get; set; }

			///
			///Container for a list of the vocabulary values for the specified attribute. For example, for a "color" attribute, vocabulary values might include "red," "green," and "blue."
			///
			public List<AttributeVocabularyValue> VocabularyValues { get; set; }

		}

}