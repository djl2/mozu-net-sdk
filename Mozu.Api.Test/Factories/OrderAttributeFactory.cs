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
	/// Use the Order Attributes resource to define how an order attribute definition applies to a specific order.
	/// </summary>
	public partial class OrderAttributeFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves a list of the attributes defined for the order specified in the request.
		/// <example> 
		///  <code> 
		/// var result = OrderAttributeFactory.GetOrderAttributes(handler : handler,  orderId :  orderId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<OrderAttribute>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> GetOrderAttributes(ServiceClientMessageHandler handler, 
 		 string orderId,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.GetOrderAttributesClient(
				 orderId :  orderId, authTicket : authTicket		);
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
		/// Applies a list of attributes to the order specified in the request and defines a value for each attribute in the request body.
		/// <example> 
		///  <code> 
		/// var result = OrderAttributeFactory.CreateOrderAttributes(handler : handler,  orderAttributes :  orderAttributes,  orderId :  orderId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<OrderAttribute>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> CreateOrderAttributes(ServiceClientMessageHandler handler, 
 		 List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, string orderId,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.CreateOrderAttributesClient(
				 orderAttributes :  orderAttributes,  orderId :  orderId, authTicket : authTicket		);
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
		/// Updates one or more properties of an attribute defined for the order specified in the request.
		/// <example> 
		///  <code> 
		/// var result = OrderAttributeFactory.UpdateOrderAttributes(handler : handler,  orderAttributes :  orderAttributes,  orderId :  orderId,  removeMissing :  removeMissing,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<OrderAttribute>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> UpdateOrderAttributes(ServiceClientMessageHandler handler, 
 		 List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderAttribute> orderAttributes, string orderId, bool? removeMissing = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderAttributeClient.UpdateOrderAttributesClient(
				 orderAttributes :  orderAttributes,  orderId :  orderId,  removeMissing :  removeMissing, authTicket : authTicket		);
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


