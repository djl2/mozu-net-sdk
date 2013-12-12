//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use this subresource to retrieve details about items in an active order.
	/// </summary>
	public partial class OrderItemFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves the details of a single order item.
		/// <example> 
		///  <code> 
		/// var result = OrderItemFactory.GetOrderItem(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  draft :  draft,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<OrderItem/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem GetOrderItem(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, bool? draft = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemClient(
				 orderId :  orderId,  orderItemId :  orderItemId,  draft :  draft, authTicket : authTicket		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (Exception ex)
			{
			 // Custom error handling for test cases can be placed here
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Retrieves the details of all items in an order.
		/// <example> 
		///  <code> 
		/// var result = OrderItemFactory.GetOrderItems(handler : handler,  orderId :  orderId,  draft :  draft,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<OrderItemCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection GetOrderItems(ServiceClientMessageHandler handler, 
 		 string orderId, bool? draft = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemsClient(
				 orderId :  orderId,  draft :  draft, authTicket : authTicket		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (Exception ex)
			{
			 // Custom error handling for test cases can be placed here
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Adds a new item to an existing order.
		/// <example> 
		///  <code> 
		/// var result = OrderItemFactory.CreateOrderItem(handler : handler,  orderItem :  orderItem,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  skipInventoryCheck :  skipInventoryCheck,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderItem(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, string orderId, string updateMode = null, string version = null, bool? skipInventoryCheck = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.CreateOrderItemClient(
				 orderItem :  orderItem,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  skipInventoryCheck :  skipInventoryCheck, authTicket : authTicket		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (Exception ex)
			{
			 // Custom error handling for test cases can be placed here
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Update the discount applied to an item in an order.
		/// <example> 
		///  <code> 
		/// var result = OrderItemFactory.UpdateOrderItemDiscount(handler : handler,  discount :  discount,  orderId :  orderId,  orderItemId :  orderItemId,  discountId :  discountId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderItemDiscount(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, string orderId, string orderItemId, int discountId, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateOrderItemDiscountClient(
				 discount :  discount,  orderId :  orderId,  orderItemId :  orderItemId,  discountId :  discountId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (Exception ex)
			{
			 // Custom error handling for test cases can be placed here
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Override the price of an individual product on a line item in the specified order.
		/// <example> 
		///  <code> 
		/// var result = OrderItemFactory.UpdateItemProductPrice(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  price :  price,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemProductPrice(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, decimal price, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemProductPriceClient(
				 orderId :  orderId,  orderItemId :  orderItemId,  price :  price,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (Exception ex)
			{
			 // Custom error handling for test cases can be placed here
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Update the quantity of an item in an order.
		/// <example> 
		///  <code> 
		/// var result = OrderItemFactory.UpdateItemQuantity(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  quantity :  quantity,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemQuantity(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, int quantity, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemQuantityClient(
				 orderId :  orderId,  orderItemId :  orderItemId,  quantity :  quantity,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (Exception ex)
			{
			 // Custom error handling for test cases can be placed here
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// Removes a previously added item from an existing order.
		/// <example> 
		///  <code> 
		/// var result = OrderItemFactory.DeleteOrderItem(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order DeleteOrderItem(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.DeleteOrderItemClient(
				 orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (Exception ex)
			{
			 // Custom error handling for test cases can be placed here
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


