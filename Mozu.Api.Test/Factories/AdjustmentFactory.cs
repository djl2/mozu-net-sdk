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
	public partial class AdjustmentFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// AdjustmentFactory.ApplyShippingAdjustment(handler : handler,  orderId :  orderId,  adjustment :  adjustment,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyShippingAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return ApplyShippingAdjustment(handler : handler,  orderId :  orderId,  updateMode :  null,  version :  null,  adjustment :  adjustment,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AdjustmentFactory.ApplyShippingAdjustment(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  adjustment :  adjustment, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyShippingAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.ApplyShippingAdjustmentClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version,  adjustment :  adjustment, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// AdjustmentFactory.ApplyAdjustment(handler : handler,  orderId :  orderId,  adjustment :  adjustment,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return ApplyAdjustment(handler : handler,  orderId :  orderId,  updateMode :  null,  version :  null,  adjustment :  adjustment,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AdjustmentFactory.ApplyAdjustment(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  adjustment :  adjustment, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.ApplyAdjustmentClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version,  adjustment :  adjustment, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// AdjustmentFactory.RemoveShippingAdjustment(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveShippingAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return RemoveShippingAdjustment(handler : handler,  orderId :  orderId,  updateMode :  null,  version :  null,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AdjustmentFactory.RemoveShippingAdjustment(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveShippingAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode, string version,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.RemoveShippingAdjustmentClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// AdjustmentFactory.RemoveAdjustment(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return RemoveAdjustment(handler : handler,  orderId :  orderId,  updateMode :  null,  version :  null,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AdjustmentFactory.RemoveAdjustment(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Order>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveAdjustment(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode, string version,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.RemoveAdjustmentClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

