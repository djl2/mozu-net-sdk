
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	public partial class AttributeVocabularyValueUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetAttributeVocabularyValues
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetAttributeVocabularyValuesUrl(string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/VocabularyValues";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetAttributeVocabularyValue
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="value">The actual unique value of the attribute vocabulary to retrieve. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetAttributeVocabularyValueUrl(string attributeFQN, string value)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/VocabularyValues/{value}";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			FormatUrl( ref url, "value", value);
			return url;
		}

				/// <summary>
        /// Get Resource Url for AddAttributeVocabularyValue
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string AddAttributeVocabularyValueUrl(string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/VocabularyValues";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			return url;
		}

				/// <summary>
        /// Get Resource Url for UpdateAttributeVocabularyValues
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateAttributeVocabularyValuesUrl(string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/VocabularyValues";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			return url;
		}

		/// <summary>
        /// Get Resource Url for UpdateAttributeVocabularyValue
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="value">The actual unique value of the attribute vocabulary value to update. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateAttributeVocabularyValueUrl(string attributeFQN, string value)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/VocabularyValues/{value}";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			FormatUrl( ref url, "value", value);
			return url;
		}

				/// <summary>
        /// Get Resource Url for DeleteAttributeVocabularyValue
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="value">The actual unique value of the attribute vocabulary to delete. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string DeleteAttributeVocabularyValueUrl(string attributeFQN, string value)
		{
			var url = "/api/commerce/catalog/admin/attributedefinition/attributes/{attributeFQN}/VocabularyValues/{value}";
			FormatUrl( ref url, "attributeFQN", attributeFQN);
			FormatUrl( ref url, "value", value);
			return url;
		}

		
	}
}
