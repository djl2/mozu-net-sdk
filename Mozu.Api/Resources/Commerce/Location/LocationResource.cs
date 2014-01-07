
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


namespace Mozu.Api.Resources.Commerce.Location
{
	/// <summary>
	/// 
	/// </summary>
	public partial class LocationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public LocationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetLocation( code, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.Location GetLocation(string code, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Location.LocationClient.GetLocationClient( code, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="locationUsageType"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetLocationInUsageType( locationUsageType,  code, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.Location GetLocationInUsageType(string locationUsageType, string code, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Location.LocationClient.GetLocationInUsageTypeClient( locationUsageType,  code, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationUsageType"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = location.GetLocationsInUsageType( locationUsageType);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.LocationCollection GetLocationsInUsageType(string locationUsageType)
		{
			return GetLocationsInUsageType( locationUsageType,  null,  null,  null,  null, null);
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
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = location.GetLocationsInUsageType( locationUsageType,  startIndex,  pageSize,  sortBy,  filter, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.LocationCollection GetLocationsInUsageType(string locationUsageType, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Location.LocationClient.GetLocationsInUsageTypeClient( locationUsageType,  startIndex,  pageSize,  sortBy,  filter, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetDirectShipLocation(authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.Location GetDirectShipLocation(AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Location.LocationClient.GetDirectShipLocationClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetInStorePickupLocation( code, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.Location GetInStorePickupLocation(string code, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Location.LocationClient.GetInStorePickupLocationClient( code, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = location.GetInStorePickupLocations();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.LocationCollection GetInStorePickupLocations()
		{
			return GetInStorePickupLocations( null,  null,  null,  null, null);
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
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = location.GetInStorePickupLocations( startIndex,  pageSize,  sortBy,  filter, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Location.LocationCollection GetInStorePickupLocations(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Location.LocationClient.GetInStorePickupLocationsClient( startIndex,  pageSize,  sortBy,  filter, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


