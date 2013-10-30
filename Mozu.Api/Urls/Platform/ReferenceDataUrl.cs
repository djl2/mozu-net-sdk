
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Platform
{
	public partial class ReferenceDataUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetAddressSchema
        /// </summary>
        /// <param name="countryCode">2 letter geographic code representing the country for the physical or mailing address. Currently limited to the US.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetAddressSchemaUrl(string countryCode)
		{
			var url = "/api/platform/reference/addressschema/{countryCode}";
			FormatUrl( ref url, "countryCode", countryCode);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetAddressSchemas
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetAddressSchemasUrl()
		{
			var url = "/api/platform/reference/addressschemas";
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetBehavior
        /// </summary>
        /// <param name="behaviorId">***Always private and should not be published.***</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetBehaviorUrl(long behaviorId)
		{
			var url = "/api/platform/reference/behaviors/{behaviorId}";
			FormatUrl( ref url, "behaviorId", behaviorId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetBehaviorCategories
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetBehaviorCategoriesUrl()
		{
			var url = "/api/platform/reference/behaviors/categories";
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetBehaviorCategory
        /// </summary>
        /// <param name="categoryId">***Always private and should not be published.***</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetBehaviorCategoryUrl(long categoryId)
		{
			var url = "/api/platform/reference/behaviors/categories/{categoryId}";
			FormatUrl( ref url, "categoryId", categoryId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetBehaviors
        /// </summary>
        /// <param name="userType"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetBehaviorsUrl(string userType)
		{
			var url = "/api/platform/reference/behaviors?userType={userType}";
			FormatUrl( ref url, "userType", userType);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetContentLocales
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetContentLocalesUrl()
		{
			var url = "/api/platform/reference/contentLocales";
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetCountries
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetCountriesUrl()
		{
			var url = "/api/platform/reference/countries";
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetCurrencies
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetCurrenciesUrl()
		{
			var url = "/api/platform/reference/currencies";
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetTimeZones
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetTimeZonesUrl()
		{
			var url = "/api/platform/reference/timezones";
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetTopLevelDomains
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetTopLevelDomainsUrl()
		{
			var url = "/api/platform/reference/topleveldomains";
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetUnitsOfMeasure
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetUnitsOfMeasureUrl(string filter)
		{
			var url = "/api/platform/reference/unitsofmeasure?filter={filter}";
			FormatUrl( ref url, "filter", filter);
			return url;
		}

								
	}
}
