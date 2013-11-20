
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


namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Manage order processing, payment, and shipping. Includes getting customer payment details, shipping address and selected shipment method, processing payment transactions, and, once paid, shipping the order to the shopper.
	/// </summary>
	public partial class OrderResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public OrderResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of orders according to any specified filter criteria and sort options.
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var orderCollection = order.GetOrders();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection GetOrders()
		{
			return GetOrders( null,  null,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of orders according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter an order's search results by any of its properties, including status, contact information, or total. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). <b>For example - "filter=Status+eq+Submitted"</b></param>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="q"></param>
		/// <param name="qLimit"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var orderCollection = order.GetOrders( filter,  pageSize,  q,  qLimit,  sortBy,  startIndex, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection GetOrders(string filter =  null, int? pageSize =  null, string q =  null, int? qLimit =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderCollection> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrdersClient( filter,  pageSize,  q,  qLimit,  sortBy,  startIndex, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves available order actions which depends on the status of the order. Actions are "CreateOrder," "SubmitOrder," "SetOrderAsProcessing," "CloseOrder," or "CancelOrder."
		/// </summary>
		/// <param name="orderId">Unique identifier of the available order actions to get.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var string = order.GetAvailableActions( orderId, authTicket);
		/// </code>
		/// </example>
		public virtual List<string> GetAvailableActions(string orderId, AuthTicket authTicket= null)
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetAvailableActionsClient( orderId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.PricingRuntime.TaxableOrder"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var taxableOrder = order.GetTaxableOrders( orderId, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder> GetTaxableOrders(string orderId, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.PricingRuntime.TaxableOrder>> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetTaxableOrdersClient( orderId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of an order specified by the order ID.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order details to get.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.GetOrder( orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order GetOrder(string orderId)
		{
			return GetOrder( orderId,  null, null);
		}

		/// <summary>
		/// Retrieves the details of an order specified by the order ID.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order, which might include uncommitted changes to the order or its components.</param>
		/// <param name="orderId">Unique identifier of the order details to get.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.GetOrder( orderId,  draft, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order GetOrder(string orderId, bool? draft =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.GetOrderClient( orderId,  draft, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Creates a new order for no-cart quick-ordering scenarios.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="order">All properties of the order to place.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.CreateOrder( order, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrder(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderClient( order, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new order from an existing cart when the customer chooses to proceed to checkout.
		/// </summary>
		/// <param name="cartId">Unique identifier of the cart. This is the original cart ID expressed as a GUID.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.CreateOrderFromCart( cartId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderFromCart(string cartId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.CreateOrderFromCartClient( cartId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Perform the specified action for an order. Available actions depend on the current status of the order. When in doubt, first get a list of available order actions.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action">Action to perform, which can be "CreateOrder," "SubmitOrder," "SetOrderAsProcessing," "CloseOrder," or "CancelOrder."</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.PerformOrderAction( action,  orderId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order PerformOrderAction(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAction action, string orderId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.PerformOrderActionClient( action,  orderId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Update the properties of a discount applied to an order.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order discount. System-supplied and read only.</param>
		/// <param name="discount">Properties of the order discount to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.UpdateOrderDiscount( discount,  discountId,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderDiscount(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, int discountId, string orderId)
		{
			return UpdateOrderDiscount( discount,  discountId,  orderId,  null,  null, null);
		}

		/// <summary>
		/// Update the properties of a discount applied to an order.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order discount. System-supplied and read only.</param>
		/// <param name="updateMode">Specifies whether to modify the discount by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="discount">Properties of the order discount to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.UpdateOrderDiscount( discount,  discountId,  orderId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderDiscount(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, int discountId, string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderDiscountClient( discount,  discountId,  orderId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes the current draft version of the order, which also deletes any uncommitted changes made to the order in draft mode.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the draft to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   order.DeleteOrderDraft( orderId);
		/// </code>
		/// </example>
		public virtual void DeleteOrderDraft(string orderId)
		{
			DeleteOrderDraft( orderId,  null, null);
		}

		/// <summary>
		/// Deletes the current draft version of the order, which also deletes any uncommitted changes made to the order in draft mode.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the draft to delete.</param>
		/// <param name="version">The version of the order draft to delete.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   order.DeleteOrderDraft( orderId,  version, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteOrderDraft(string orderId, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.DeleteOrderDraftClient( orderId,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.ChangeOrderUserId( orderId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ChangeOrderUserId(string orderId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.ChangeOrderUserIdClient( orderId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the specified order when additional order information, such as shipping or billing information, is modified during the checkout process.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to update.</param>
		/// <param name="order">The properties of the order to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.UpdateOrder( order,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrder(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId)
		{
			return UpdateOrder( order,  orderId,  null,  null, null);
		}

		/// <summary>
		/// Updates the specified order when additional order information, such as shipping or billing information, is modified during the checkout process.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to update.</param>
		/// <param name="updateMode">Specifies whether to update the original order, update the order in draft mode, or update the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="order">The properties of the order to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var order = new Order();
		///   var order = order.UpdateOrder( order,  orderId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrder(Mozu.Api.Contracts.CommerceRuntime.Orders.Order order, string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.OrderClient.UpdateOrderClient( order,  orderId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				
	}

}


