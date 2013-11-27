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
	public partial class ReturnFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// ReturnFactory.GetReturns(handler : handler,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection GetReturns(ServiceClientMessageHandler handler, 
 		 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetReturns(handler : handler,  filter :  null,  pageSize :  null,  sortBy :  null,  startIndex :  null,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.GetReturns(handler : handler,  filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<ReturnCollection>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection GetReturns(ServiceClientMessageHandler handler, 
 		 string filter, int? pageSize, string sortBy, int? startIndex,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.GetReturnsClient(
				 filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.GetReturn(handler : handler,  returnId :  returnId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Return>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.Return GetReturn(ServiceClientMessageHandler handler, 
 		 string returnId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.GetReturnClient(
				 returnId :  returnId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.GetAvailableReturnActions(handler : handler,  returnId :  returnId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<string>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<string> GetAvailableReturnActions(ServiceClientMessageHandler handler, 
 		 string returnId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.GetAvailableReturnActionsClient(
				 returnId :  returnId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.GetPayments(handler : handler,  returnId :  returnId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<PaymentCollection>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection GetPayments(ServiceClientMessageHandler handler, 
 		 string returnId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.GetPaymentsClient(
				 returnId :  returnId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.GetPayment(handler : handler,  paymentId :  paymentId,  returnId :  returnId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Payment>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Payments.Payment GetPayment(ServiceClientMessageHandler handler, 
 		 string paymentId, string returnId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.GetPaymentClient(
				 paymentId :  paymentId,  returnId :  returnId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.GetAvailablePaymentActionsForReturn(handler : handler,  paymentId :  paymentId,  returnId :  returnId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<string>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<string> GetAvailablePaymentActionsForReturn(ServiceClientMessageHandler handler, 
 		 string paymentId, string returnId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.GetAvailablePaymentActionsForReturnClient(
				 paymentId :  paymentId,  returnId :  returnId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.CreateReturn(handler : handler,  ret :  ret, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Return>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.Return CreateReturn(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.CreateReturnClient(
				 ret :  ret, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.PerformPaymentActionForReturn(handler : handler,  paymentId :  paymentId,  returnId :  returnId,  action :  action, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Return>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.Return PerformPaymentActionForReturn(ServiceClientMessageHandler handler, 
 		 string paymentId, string returnId, Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.PerformPaymentActionForReturnClient(
				 paymentId :  paymentId,  returnId :  returnId,  action :  action, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.CreatePaymentActionForReturn(handler : handler,  returnId :  returnId,  action :  action, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Return>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.Return CreatePaymentActionForReturn(ServiceClientMessageHandler handler, 
 		 string returnId, Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.CreatePaymentActionForReturnClient(
				 returnId :  returnId,  action :  action, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.PerformReturnActions(handler : handler,  action :  action, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<ReturnCollection>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection PerformReturnActions(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.PerformReturnActionsClient(
				 action :  action, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.UpdateReturn(handler : handler,  returnId :  returnId,  ret :  ret, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Return>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Returns.Return UpdateReturn(ServiceClientMessageHandler handler, 
 		 string returnId, Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.UpdateReturnClient(
				 returnId :  returnId,  ret :  ret, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ReturnFactory.DeleteReturn(handler : handler,  returnId :  returnId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<void>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteReturn(ServiceClientMessageHandler handler, 
 		string returnId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.ReturnClient.DeleteReturnClient(
				 returnId :  returnId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

