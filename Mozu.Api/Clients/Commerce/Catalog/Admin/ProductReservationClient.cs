
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


namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Temporarily hold a product from inventory while a shopper is filling out payment information. Create a product reservation when a shopper proceeds to check out and then release the reservation when the order process is complete.
	/// </summary>
	public partial class ProductReservationClient 	{
		
		/// <summary>
		/// Retrieves a list of product reservations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductReservations(dataViewMode);
		///   var productReservationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection> GetProductReservationsClient(DataViewMode dataViewMode)
		{
			return GetProductReservationsClient(dataViewMode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of product reservations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">"A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - ""filter=IsDisplayed+eq+true"""</param>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductReservations(dataViewMode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
		///   var productReservationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection> GetProductReservationsClient(DataViewMode dataViewMode, string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.GetProductReservationsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a product reservation.
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the product reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductReservation(dataViewMode,  productReservationId, authTicket);
		///   var productReservationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation> GetProductReservationClient(DataViewMode dataViewMode, int productReservationId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.GetProductReservationUrl(productReservationId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Creates a new product reservation for a product. This action places a hold on the product inventory for the quantity specified during the ordering process.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productReservation">Properties of the product reservation.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddProductReservation(dataViewMode,  productReservation, authTicket);
		///   var productReservationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation> AddProductReservationClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductReservation productReservation, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.AddProductReservationUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ProductAdmin.ProductReservation>(productReservation).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Commits a product reservation to decrement the product's inventory by the quantity specified then release the reservation once the order process completed successfully.
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the reservation.</param>
		/// <param name="qty">Number of product items to remove from inventory.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CommitReservation(dataViewMode,  productReservationId,  qty, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient CommitReservationClient(DataViewMode dataViewMode, int productReservationId, int qty, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.CommitReservationUrl(productReservationId, qty);
			const string verb = "POST";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Updates an existing product reservation for a product. 
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the product reservation to update. </param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productReservation">Properties of the product reservation to update. </param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductReservation(dataViewMode,  productReservation,  productReservationId, authTicket);
		///   var productReservationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation> UpdateProductReservationClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductReservation productReservation, int productReservationId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.UpdateProductReservationUrl(productReservationId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ProductAdmin.ProductReservation>(productReservation).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Deletes a product reservation. For example, delete a reservation when an order is not processed to return the product quantity back to inventory.
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProductReservation(dataViewMode,  productReservationId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteProductReservationClient(DataViewMode dataViewMode, int productReservationId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductReservationUrl.DeleteProductReservationUrl(productReservationId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


