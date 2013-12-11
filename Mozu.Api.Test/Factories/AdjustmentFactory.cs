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
	/// Use this subresource to manage ad-hoc order level price adjustments.
	/// </summary>
	public partial class AdjustmentFactory : BaseDataFactory
	{

		/// <summary> 
		/// Applies a shipping adjustment to the specified order.
		/// <example> 
		///  <code> 
		/// var result = AdjustmentFactory.ApplyShippingAdjustment(handler : handler,  adjustment :  adjustment,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyShippingAdjustment(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment, string orderId, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.ApplyShippingAdjustmentClient(
				 adjustment :  adjustment,  orderId :  orderId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
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
		/// Applies a price adjustment to the specified order.
		/// <example> 
		///  <code> 
		/// var result = AdjustmentFactory.ApplyAdjustment(handler : handler,  adjustment :  adjustment,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyAdjustment(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment, string orderId, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.ApplyAdjustmentClient(
				 adjustment :  adjustment,  orderId :  orderId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
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
		/// Removes a shipping adjustment previously applied to an order or draft.
		/// <example> 
		///  <code> 
		/// var result = AdjustmentFactory.RemoveShippingAdjustment(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveShippingAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.RemoveShippingAdjustmentClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
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
		/// Removes a price adjustment from the specified order.
		/// <example> 
		///  <code> 
		/// var result = AdjustmentFactory.RemoveAdjustment(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Order/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode = null, string version = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.RemoveAdjustmentClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
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


