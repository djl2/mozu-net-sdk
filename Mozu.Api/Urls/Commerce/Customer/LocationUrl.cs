
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Customer
{
	public partial class LocationUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetLocation
        /// </summary>
        /// <param name="locationId">Identifier of the location being retrieved.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetLocationUrl(int locationId)
		{
			var url = "/api/commerce/customer/locations/locations/{locationId}";
			FormatUrl( ref url, "locationId", locationId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetLocationByName
        /// </summary>
        /// <param name="name">The name of the location.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetLocationByNameUrl(string name)
		{
			var url = "/api/commerce/customer/locations/locations?name={name}&";
			FormatUrl( ref url, "name", name);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetLocations
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetLocationsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/customer/locations/locations?pageIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&&filter={filter}";
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sortBy", sortBy);
			FormatUrl( ref url, "startIndex", startIndex);
			return url;
		}

								
	}
}

