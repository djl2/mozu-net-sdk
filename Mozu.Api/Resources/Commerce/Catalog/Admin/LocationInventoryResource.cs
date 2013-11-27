
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// 
	/// </summary>
	public partial class LocationInventoryResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public LocationInventoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode"></param>
		/// <param name="productCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.GetLocationInventory(dataViewMode,  locationCode,  productCode, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.LocationInventory GetLocationInventory(DataViewMode dataViewMode, string locationCode, string productCode, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.GetLocationInventoryClient(dataViewMode,  locationCode,  productCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventoryCollection = locationinventory.GetLocationInventories(dataViewMode,  locationCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection GetLocationInventories(DataViewMode dataViewMode, string locationCode)
		{
			return GetLocationInventories(dataViewMode,  locationCode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="locationCode"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventoryCollection = locationinventory.GetLocationInventories(dataViewMode,  locationCode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection GetLocationInventories(DataViewMode dataViewMode, string locationCode, string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.GetLocationInventoriesClient(dataViewMode,  locationCode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="locationInventoryList"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.AddLocationInventory(dataViewMode,  locationInventoryList,  locationCode, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> AddLocationInventory(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string locationCode, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.AddLocationInventoryClient(dataViewMode,  locationInventoryList,  locationCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="locationInventoryAdjustments"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   var locationInventory = locationinventory.UpdateLocationInventory(dataViewMode,  locationInventoryAdjustments,  locationCode, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> UpdateLocationInventory(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string locationCode, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.UpdateLocationInventoryClient(dataViewMode,  locationInventoryAdjustments,  locationCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="locationCode"></param>
		/// <param name="productCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var locationinventory = new LocationInventory();
		///   locationinventory.DeleteLocationInventory(dataViewMode,  locationCode,  productCode, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteLocationInventory(DataViewMode dataViewMode, string locationCode, string productCode, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventoryClient.DeleteLocationInventoryClient(dataViewMode,  locationCode,  productCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


