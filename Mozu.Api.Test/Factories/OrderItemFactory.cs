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
	/// 
	/// </summary>
	public partial class OrderItemFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderItemFactory.GetOrderItem(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem GetOrderItem(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetOrderItem(handler : handler,  draft :  null,  orderId :  orderId,  orderItemId :  orderItemId, authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderItemFactory.GetOrderItem(handler : handler,  draft :  draft,  orderId :  orderId,  orderItemId :  orderItemId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<OrderItem>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem GetOrderItem(ServiceClientMessageHandler handler, 
 		 bool? draft, string orderId, string orderItemId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemClient(
				 draft :  draft,  orderId :  orderId,  orderItemId :  orderItemId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderItemFactory.GetOrderItems(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection GetOrderItems(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetOrderItems(handler : handler,  draft :  null,  orderId :  orderId, authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderItemFactory.GetOrderItems(handler : handler,  draft :  draft,  orderId :  orderId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<OrderItemCollection>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItemCollection GetOrderItems(ServiceClientMessageHandler handler, 
 		 bool? draft, string orderId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.GetOrderItemsClient(
				 draft :  draft,  orderId :  orderId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderItemFactory.CreateOrderItem(handler : handler,  orderId :  orderId,  orderItem :  orderItem,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderItem(ServiceClientMessageHandler handler, 
 		 string orderId, Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return CreateOrderItem(handler : handler,  orderId :  orderId,  updateMode :  null,  version :  null,  orderItem :  orderItem,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderItemFactory.CreateOrderItem(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  orderItem :  orderItem, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order CreateOrderItem(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Orders.OrderItem orderItem, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.CreateOrderItemClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version,  orderItem :  orderItem, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderItemFactory.UpdateOrderItemDiscount(handler : handler,  discountId :  discountId,  orderId :  orderId,  orderItemId :  orderItemId,  discount :  discount,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderItemDiscount(ServiceClientMessageHandler handler, 
 		 int discountId, string orderId, string orderItemId, Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return UpdateOrderItemDiscount(handler : handler,  discountId :  discountId,  orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  null,  version :  null,  discount :  discount,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderItemFactory.UpdateOrderItemDiscount(handler : handler,  discountId :  discountId,  orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  updateMode,  version :  version,  discount :  discount, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateOrderItemDiscount(ServiceClientMessageHandler handler, 
 		 int discountId, string orderId, string orderItemId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Discounts.AppliedDiscount discount, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateOrderItemDiscountClient(
				 discountId :  discountId,  orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  updateMode,  version :  version,  discount :  discount, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderItemFactory.UpdateItemProductPrice(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  price :  price,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemProductPrice(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, decimal price, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return UpdateItemProductPrice(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  price :  price,  updateMode :  null,  version :  null,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderItemFactory.UpdateItemProductPrice(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  price :  price,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemProductPrice(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, decimal price, string updateMode, string version,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemProductPriceClient(
				 orderId :  orderId,  orderItemId :  orderItemId,  price :  price,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderItemFactory.UpdateItemQuantity(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  quantity :  quantity,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemQuantity(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, int quantity, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return UpdateItemQuantity(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  quantity :  quantity,  updateMode :  null,  version :  null,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderItemFactory.UpdateItemQuantity(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  quantity :  quantity,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order UpdateItemQuantity(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, int quantity, string updateMode, string version,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.UpdateItemQuantityClient(
				 orderId :  orderId,  orderItemId :  orderItemId,  quantity :  quantity,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderItemFactory.DeleteOrderItem(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order DeleteOrderItem(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return DeleteOrderItem(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  null,  version :  null,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderItemFactory.DeleteOrderItem(handler : handler,  orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order DeleteOrderItem(ServiceClientMessageHandler handler, 
 		 string orderId, string orderItemId, string updateMode, string version,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderItemClient.DeleteOrderItemClient(
				 orderId :  orderId,  orderItemId :  orderItemId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


