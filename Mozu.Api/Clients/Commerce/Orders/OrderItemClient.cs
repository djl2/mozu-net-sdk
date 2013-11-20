
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


namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use this subresource to retrieve details about items in an active order.
	/// </summary>
	public partial class OrderItemClient 	{
		
		/// <summary>
		/// Retrieves the details of a single order item.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order item to retrieve.</param>
		/// <param name="orderItemId">Unique identifier of the order item details to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderItem( orderId,  orderItemId);
		///   var orderItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem> GetOrderItemClient(string orderId, string orderItemId)
		{
			return GetOrderItemClient( orderId,  orderItemId,  null, null);
		}

		/// <summary>
		/// Retrieves the details of a single order item.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of this order item, which might include uncommitted changes to the order item, the order, or other order components.</param>
		/// <param name="orderId">Unique identifier of the order item to retrieve.</param>
		/// <param name="orderItemId">Unique identifier of the order item details to retrieve.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderItem( orderId,  orderItemId,  draft, authTicket);
		///   var orderItemClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem> GetOrderItemClient(string orderId, string orderItemId, bool? draft =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderItemUrl.GetOrderItemUrl(draft, orderId, orderItemId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of all items in an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order items to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderItems( orderId);
		///   var orderItemCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection> GetOrderItemsClient(string orderId)
		{
			return GetOrderItemsClient( orderId,  null, null);
		}

		/// <summary>
		/// Retrieves the details of all items in an order.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order's items, which might include uncommitted changes to one or more order items, the order itself, or other order components.</param>
		/// <param name="orderId">Unique identifier of the order items to retrieve.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrderItems( orderId,  draft, authTicket);
		///   var orderItemCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection> GetOrderItemsClient(string orderId, bool? draft =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderItemUrl.GetOrderItemsUrl(draft, orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Adds a new item to an existing order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to add the item.</param>
		/// <param name="orderItem">The properties of the item to create in the existing order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrderItem( orderItem,  orderId);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderItemClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId)
		{
			return CreateOrderItemClient( orderItem,  orderId,  null,  null, null);
		}

		/// <summary>
		/// Adds a new item to an existing order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to add the item.</param>
		/// <param name="updateMode">Specifies whether to add the item by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="orderItem">The properties of the item to create in the existing order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateOrderItem( orderItem,  orderId,  updateMode,  version, authTicket);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> CreateOrderItemClient(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderItemUrl.CreateOrderItemUrl(orderId, updateMode, version);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem>(orderItem);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Update the discount applied to an item in an order.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order associated with the item discount.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order.</param>
		/// <param name="discount">Properties of the discount to modify for the order item.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrderItemDiscount( discount,  discountId,  orderId,  orderItemId);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderItemDiscountClient(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, int discountId, string orderId, string orderItemId)
		{
			return UpdateOrderItemDiscountClient( discount,  discountId,  orderId,  orderItemId,  null,  null, null);
		}

		/// <summary>
		/// Update the discount applied to an item in an order.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
		/// <param name="orderId">Unique identifier of the order associated with the item discount.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order.</param>
		/// <param name="updateMode">Specifies whether to change the item discount by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="discount">Properties of the discount to modify for the order item.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateOrderItemDiscount( discount,  discountId,  orderId,  orderItemId,  updateMode,  version, authTicket);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateOrderItemDiscountClient(Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, int discountId, string orderId, string orderItemId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderItemUrl.UpdateOrderItemDiscountUrl(discountId, orderId, orderItemId, updateMode, version);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount>(discount);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Override the price of an individual product in the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order containing the item to price override.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order to price override.</param>
		/// <param name="price">The override price to specify for this item in the specified order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateItemProductPrice( orderId,  orderItemId,  price);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateItemProductPriceClient(string orderId, string orderItemId, decimal price)
		{
			return UpdateItemProductPriceClient( orderId,  orderItemId,  price,  null,  null, null);
		}

		/// <summary>
		/// Override the price of an individual product in the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order containing the item to price override.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order to price override.</param>
		/// <param name="price">The override price to specify for this item in the specified order.</param>
		/// <param name="updateMode">Specifies whether to change the product price by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateItemProductPrice( orderId,  orderItemId,  price,  updateMode,  version, authTicket);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateItemProductPriceClient(string orderId, string orderItemId, decimal price, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderItemUrl.UpdateItemProductPriceUrl(orderId, orderItemId, price, updateMode, version);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Update the quantity of an item in an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order containing the item to update quantity.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order to update quantity.</param>
		/// <param name="quantity">The quantity of the item in the order to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateItemQuantity( orderId,  orderItemId,  quantity);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateItemQuantityClient(string orderId, string orderItemId, int quantity)
		{
			return UpdateItemQuantityClient( orderId,  orderItemId,  quantity,  null,  null, null);
		}

		/// <summary>
		/// Update the quantity of an item in an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order containing the item to update quantity.</param>
		/// <param name="orderItemId">Unique identifier of the item in the order to update quantity.</param>
		/// <param name="quantity">The quantity of the item in the order to update.</param>
		/// <param name="updateMode">Specifies whether to change the item quantity by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateItemQuantity( orderId,  orderItemId,  quantity,  updateMode,  version, authTicket);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> UpdateItemQuantityClient(string orderId, string orderItemId, int quantity, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderItemUrl.UpdateItemQuantityUrl(orderId, orderItemId, quantity, updateMode, version);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Removes a previously added item from an existing order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the item to remove.</param>
		/// <param name="orderItemId">Unique identifier of the item to remove from the order.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOrderItem( orderId,  orderItemId);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> DeleteOrderItemClient(string orderId, string orderItemId)
		{
			return DeleteOrderItemClient( orderId,  orderItemId,  null,  null, null);
		}

		/// <summary>
		/// Removes a previously added item from an existing order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the item to remove.</param>
		/// <param name="orderItemId">Unique identifier of the item to remove from the order.</param>
		/// <param name="updateMode">Specifies whether to remove the item by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committoing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteOrderItem( orderId,  orderItemId,  updateMode,  version, authTicket);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> DeleteOrderItemClient(string orderId, string orderItemId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.OrderItemUrl.DeleteOrderItemUrl(orderId, orderItemId, updateMode, version);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


