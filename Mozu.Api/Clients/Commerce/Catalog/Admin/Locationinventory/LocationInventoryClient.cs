
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Commerce.Catalog.Admin.LocationInventory
{
	/// <summary>
	/// Use the Location Inventory resource to manage the level of active product inventory maintained at each defined location, at the location level.
	/// </summary>
	public partial class LocationInventoryClient 	{
		
		/// <summary>
		/// Retrieves the details of a product's active inventory at the location specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInventory(dataViewMode,  locationCode,  productCode);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory> GetLocationInventoryClient(DataViewMode dataViewMode, string locationCode, string productCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventory.LocationInventoryUrl.GetLocationInventoryUrl(locationCode, productCode);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventory>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of all product inventory definitions for the location code specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInventories(dataViewMode,  locationCode);
		///   var locationInventoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> GetLocationInventoriesClient(DataViewMode dataViewMode, string locationCode)
		{
			return GetLocationInventoriesClient(dataViewMode,  locationCode,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of all product inventory definitions for the location code specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationInventories(dataViewMode,  locationCode,  startIndex,  pageSize,  sortBy,  filter);
		///   var locationInventoryCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection> GetLocationInventoriesClient(DataViewMode dataViewMode, string locationCode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventory.LocationInventoryUrl.GetLocationInventoriesUrl(filter, locationCode, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.LocationInventoryCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Creates an array of product inventory definitions for the location specified in the request. When adding a new inventory definition, you must specify the productCode and stockOnHand value in each array you define. All other properties are system-supplied and read only.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="locationInventoryList">Array list of product inventory definitions for all associated locations. For each location inventory in the list, define the productCode and stockOnHand values.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLocationInventory(dataViewMode,  locationInventoryList,  locationCode);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> AddLocationInventoryClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string locationCode)
		{
			return AddLocationInventoryClient(dataViewMode,  locationInventoryList,  locationCode,  null);
		}

		/// <summary>
		/// Creates an array of product inventory definitions for the location specified in the request. When adding a new inventory definition, you must specify the productCode and stockOnHand value in each array you define. All other properties are system-supplied and read only.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="performUpserts"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="locationInventoryList">Array list of product inventory definitions for all associated locations. For each location inventory in the list, define the productCode and stockOnHand values.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLocationInventory(dataViewMode,  locationInventoryList,  locationCode,  performUpserts);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> AddLocationInventoryClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventory> locationInventoryList, string locationCode, bool? performUpserts =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventory.LocationInventoryUrl.AddLocationInventoryUrl(locationCode, performUpserts);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>(locationInventoryList)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the active stock on hand inventory of products for the location code specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="locationInventoryAdjustments"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.LocationInventory"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateLocationInventory(dataViewMode,  locationInventoryAdjustments,  locationCode);
		///   var locationInventoryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>> UpdateLocationInventoryClient(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment> locationInventoryAdjustments, string locationCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventory.LocationInventoryUrl.UpdateLocationInventoryUrl(locationCode);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.LocationInventory>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.LocationInventoryAdjustment>>(locationInventoryAdjustments)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the product code inventory definition for the location specified in the request.
		/// </summary>
		/// <param name="locationCode">User-defined code that uniquely identifies the location.</param>
		/// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteLocationInventory(dataViewMode,  locationCode,  productCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteLocationInventoryClient(DataViewMode dataViewMode, string locationCode, string productCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.LocationInventory.LocationInventoryUrl.DeleteLocationInventoryUrl(locationCode, productCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


