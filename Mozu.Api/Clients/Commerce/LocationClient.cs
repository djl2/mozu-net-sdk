
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


namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// 
	/// </summary>
	public partial class LocationClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.Location"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocation( code, authTicket);
		///   var locationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.Location> GetLocationClient(string code, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetLocationUrl(code);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.Location>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="locationUsageType"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.Location"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInUsageType( locationUsageType,  code, authTicket);
		///   var locationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.Location> GetLocationInUsageTypeClient(string locationUsageType, string code, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetLocationInUsageTypeUrl(code, locationUsageType);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.Location>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationUsageType"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationsInUsageType( locationUsageType);
		///   var locationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationCollection> GetLocationsInUsageTypeClient(string locationUsageType)
		{
			return GetLocationsInUsageTypeClient( locationUsageType,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="locationUsageType"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationsInUsageType( locationUsageType,  startIndex,  pageSize,  sortBy,  filter, authTicket);
		///   var locationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationCollection> GetLocationsInUsageTypeClient(string locationUsageType, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetLocationsInUsageTypeUrl(filter, locationUsageType, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.Location"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDirectShipLocation(authTicket);
		///   var locationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.Location> GetDirectShipLocationClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetDirectShipLocationUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.Location>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.Location"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetInStorePickupLocation( code, authTicket);
		///   var locationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.Location> GetInStorePickupLocationClient(string code, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetInStorePickupLocationUrl(code);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.Location>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetInStorePickupLocations();
		///   var locationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationCollection> GetInStorePickupLocationsClient()
		{
			return GetInStorePickupLocationsClient( null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetInStorePickupLocations( startIndex,  pageSize,  sortBy,  filter, authTicket);
		///   var locationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationCollection> GetInStorePickupLocationsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetInStorePickupLocationsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}


	}

}


