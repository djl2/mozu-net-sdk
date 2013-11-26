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
	public partial class OrderAttributeFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderAttributeFactory.GetOrderAttributes(handler : handler,  orderId :  orderId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<OrderAttribute>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> GetOrderAttributes(ServiceClientMessageHandler handler, 
 		 string orderId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.GetOrderAttributesClient(
				 orderId :  orderId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderAttributeFactory.CreateOrderAttributes(handler : handler,  orderId :  orderId,  orderAttributes :  orderAttributes, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<OrderAttribute>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> CreateOrderAttributes(ServiceClientMessageHandler handler, 
 		 string orderId, List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.CreateOrderAttributesClient(
				 orderId :  orderId,  orderAttributes :  orderAttributes, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// OrderAttributeFactory.UpdateOrderAttributes(handler : handler,  orderId :  orderId,  orderAttributes :  orderAttributes,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> UpdateOrderAttributes(ServiceClientMessageHandler handler, 
 		 string orderId, List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return UpdateOrderAttributes(handler : handler,  orderId :  orderId,  removeMissing :  null,  orderAttributes :  orderAttributes,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = OrderAttributeFactory.UpdateOrderAttributes(handler : handler,  orderId :  orderId,  removeMissing :  removeMissing,  orderAttributes :  orderAttributes, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<OrderAttribute>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> UpdateOrderAttributes(ServiceClientMessageHandler handler, 
 		 string orderId, bool? removeMissing, List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.UpdateOrderAttributesClient(
				 orderId :  orderId,  removeMissing :  removeMissing,  orderAttributes :  orderAttributes, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


