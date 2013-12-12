
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
	/// Temporarily hold a product from inventory while a shopper is filling out payment information. Create a product reservation when a shopper proceeds to check out and then release the reservation when the order process is complete.
	/// </summary>
	public partial class ProductReservationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public ProductReservationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of product reservations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservationCollection = productreservation.GetProductReservations(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection GetProductReservations(DataViewMode dataViewMode)
		{
			return GetProductReservations(dataViewMode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of product reservations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservationCollection = productreservation.GetProductReservations(dataViewMode,  startIndex,  pageSize,  sortBy,  filter, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection GetProductReservations(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.GetProductReservationsClient(dataViewMode,  startIndex,  pageSize,  sortBy,  filter, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a product reservation.
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the product reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = productreservation.GetProductReservation(dataViewMode,  productReservationId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductReservation GetProductReservation(DataViewMode dataViewMode, int productReservationId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductReservation> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.GetProductReservationClient(dataViewMode,  productReservationId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = productreservation.AddProductReservations(dataViewMode,  productReservations);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> AddProductReservations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations)
		{
			return AddProductReservations(dataViewMode,  productReservations,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="skipInventoryCheck"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productReservations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = productreservation.AddProductReservations(dataViewMode,  productReservations,  skipInventoryCheck, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> AddProductReservations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, bool? skipInventoryCheck =  null, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.AddProductReservationsClient(dataViewMode,  productReservations,  skipInventoryCheck, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productReservations"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   productreservation.CommitReservations(dataViewMode,  productReservations, authTicket);
		/// </code>
		/// </example>
		public virtual void CommitReservations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.CommitReservationsClient(dataViewMode,  productReservations, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productReservations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = productreservation.UpdateProductReservations(dataViewMode,  productReservations);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> UpdateProductReservations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations)
		{
			return UpdateProductReservations(dataViewMode,  productReservations,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="skipInventoryCheck"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productReservations"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductReservation"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   var productReservation = productreservation.UpdateProductReservations(dataViewMode,  productReservations,  skipInventoryCheck, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> UpdateProductReservations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductReservation> productReservations, bool? skipInventoryCheck =  null, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductReservation>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.UpdateProductReservationsClient(dataViewMode,  productReservations,  skipInventoryCheck, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes a product reservation. For example, delete a reservation when an order is not processed to return the product quantity back to inventory.
		/// </summary>
		/// <param name="productReservationId">Unique identifier of the reservation.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productreservation = new ProductReservation();
		///   productreservation.DeleteProductReservation(dataViewMode,  productReservationId, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteProductReservation(DataViewMode dataViewMode, int productReservationId, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.ProductReservationClient.DeleteProductReservationClient(dataViewMode,  productReservationId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


