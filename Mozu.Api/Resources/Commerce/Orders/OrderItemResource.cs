
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


namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// 
	/// </summary>
	public partial class OrderItemResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public OrderItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var orderItem = orderitem.GetOrderItem( orderId,  orderItemId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem GetOrderItem(string orderId, string orderItemId)
		{
			return GetOrderItem( orderId,  orderItemId,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="draft"></param>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var orderItem = orderitem.GetOrderItem( orderId,  orderItemId,  draft, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem GetOrderItem(string orderId, string orderItemId, bool? draft =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemClient( orderId,  orderItemId,  draft, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var orderItemCollection = orderitem.GetOrderItems( orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection GetOrderItems(string orderId)
		{
			return GetOrderItems( orderId,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="draft"></param>
		/// <param name="orderId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var orderItemCollection = orderitem.GetOrderItems( orderId,  draft, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection GetOrderItems(string orderId, bool? draft =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemsClient( orderId,  draft, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItem"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.CreateOrderItem( orderItem,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderItem(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId)
		{
			return CreateOrderItem( orderItem,  orderId,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="orderItem"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.CreateOrderItem( orderItem,  orderId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderItem(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.CreateOrderItemClient( orderItem,  orderId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="discount"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateOrderItemDiscount( discount,  discountId,  orderId,  orderItemId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderItemDiscount(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, int discountId, string orderId, string orderItemId)
		{
			return UpdateOrderItemDiscount( discount,  discountId,  orderId,  orderItemId,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="discount"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateOrderItemDiscount( discount,  discountId,  orderId,  orderItemId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderItemDiscount(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, int discountId, string orderId, string orderItemId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateOrderItemDiscountClient( discount,  discountId,  orderId,  orderItemId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="price"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateItemProductPrice( orderId,  orderItemId,  price);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemProductPrice(string orderId, string orderItemId, decimal price)
		{
			return UpdateItemProductPrice( orderId,  orderItemId,  price,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="price"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateItemProductPrice( orderId,  orderItemId,  price,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemProductPrice(string orderId, string orderItemId, decimal price, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemProductPriceClient( orderId,  orderItemId,  price,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="quantity"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateItemQuantity( orderId,  orderItemId,  quantity);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemQuantity(string orderId, string orderItemId, int quantity)
		{
			return UpdateItemQuantity( orderId,  orderItemId,  quantity,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="quantity"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.UpdateItemQuantity( orderId,  orderItemId,  quantity,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemQuantity(string orderId, string orderItemId, int quantity, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemQuantityClient( orderId,  orderItemId,  quantity,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.DeleteOrderItem( orderId,  orderItemId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order DeleteOrderItem(string orderId, string orderItemId)
		{
			return DeleteOrderItem( orderId,  orderItemId,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="orderItemId"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var orderitem = new OrderItem();
		///   var order = orderitem.DeleteOrderItem( orderId,  orderItemId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order DeleteOrderItem(string orderId, string orderItemId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.DeleteOrderItemClient( orderId,  orderItemId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		
	}

}


