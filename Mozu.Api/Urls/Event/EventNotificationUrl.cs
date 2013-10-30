
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Event
{
	public partial class EventNotificationUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetEvents
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetEventsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/event/pull/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sortBy", sortBy);
			FormatUrl( ref url, "startIndex", startIndex);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetEvent
        /// </summary>
        /// <param name="eventId">The unique identifier of the event being retrieved. An event is a notification about a create, read, update, or delete on an order, product, discount or category.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetEventUrl(string eventId)
		{
			var url = "/api/event/pull/{eventId}";
			FormatUrl( ref url, "eventId", eventId);
			return url;
		}

								
	}
}

