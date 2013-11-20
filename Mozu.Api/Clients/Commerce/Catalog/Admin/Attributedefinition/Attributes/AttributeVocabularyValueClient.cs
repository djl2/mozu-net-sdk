
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
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// Vocabulary values are predefined for an attribute.
	/// </summary>
	public partial class AttributeVocabularyValueClient 	{
		
		/// <summary>
		/// Retrieves a list of attribute vocabulary values. To target a query, use one or several valid optional response groups.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValues(dataViewMode,  attributeFQN, authTicket);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> GetAttributeVocabularyValuesClient(DataViewMode dataViewMode, string attributeFQN, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.GetAttributeVocabularyValuesUrl(attributeFQN);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves an attribute vocabulary value by providing the attribute FQN and value.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="value">The actual unique value of the attribute vocabulary to retrieve. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValue(dataViewMode,  attributeFQN,  value, authTicket);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> GetAttributeVocabularyValueClient(DataViewMode dataViewMode, string attributeFQN, string value, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.GetAttributeVocabularyValueUrl(attributeFQN, value);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Adds a new attribute vocabulary value.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAttributeVocabularyValue(dataViewMode,  attributeVocabularyValue,  attributeFQN, authTicket);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> AddAttributeVocabularyValueClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.AddAttributeVocabularyValueUrl(attributeFQN);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>(attributeVocabularyValue).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Update existing vocabulary values for an attribute.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="vocabularyValues">The actual vocabulary values for the attribute being updated.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAttributeVocabularyValues(dataViewMode,  vocabularyValues,  attributeFQN, authTicket);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>> UpdateAttributeVocabularyValuesClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> vocabularyValues, string attributeFQN, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.UpdateAttributeVocabularyValuesUrl(attributeFQN);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>>().WithVerb(verb).WithResourceUrl(url).WithBody<List<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>>(vocabularyValues).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Updates existing attribute vocabulary values.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="value">The actual unique value of the attribute vocabulary value to update. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="attributeVocabularyValue">The predefined vocabulary value to add to the attribute content to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAttributeVocabularyValue(dataViewMode,  attributeVocabularyValue,  attributeFQN,  value, authTicket);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue> UpdateAttributeVocabularyValueClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue attributeVocabularyValue, string attributeFQN, string value, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.UpdateAttributeVocabularyValueUrl(attributeFQN, value);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeVocabularyValue>(attributeVocabularyValue).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Deletes an attribute's vocabulary value.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="value">The actual unique value of the attribute vocabulary to delete. A single attribute must have a unique value and match the attribute's data type. If a string value returns null, the system will generate a value. The actual string content displayed shoud be stored as "Content" and actual content is required for string values.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAttributeVocabularyValue(dataViewMode,  attributeFQN,  value, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAttributeVocabularyValueClient(DataViewMode dataViewMode, string attributeFQN, string value, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeVocabularyValueUrl.DeleteAttributeVocabularyValueUrl(attributeFQN, value);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


