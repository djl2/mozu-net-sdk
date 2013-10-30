
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

namespace Mozu.Api.Clients.Event
{
	/// <summary>
	/// Use the events resource to retreive events, which are notifications about a create, read, update, or delete operation.
	/// </summary>
	public partial class EventNotificationClient 	{
		
		/// <summary>
		/// Retrieves a list of events.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Event.EventCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEvents();
		///   var eventCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Event.EventCollection> GetEventsClient()
		{
			return GetEventsClient( null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of events.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Event.EventCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEvents( filter,  pageSize,  sortBy,  startIndex);
		///   var eventCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Event.EventCollection> GetEventsClient(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = Mozu.Api.Urls.Event.EventNotificationUrl.GetEventsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Event.EventCollection>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// Retrieves an event by providing the event ID.
		/// </summary>
		/// <param name="eventId">The unique identifier of the event being retrieved. An event is a notification about a create, read, update, or delete on an order, product, discount or category.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Event.Event"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEvent( eventId);
		///   var eventClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Event.Event> GetEventClient(string eventId)
		{
			var url = Mozu.Api.Urls.Event.EventNotificationUrl.GetEventUrl(eventId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Event.Event>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

								
	}

}


