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
	public partial class BillingInfoFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// BillingInfoFactory.GetBillingInfo(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo GetBillingInfo(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetBillingInfo(handler : handler,  draft :  null,  orderId :  orderId, authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = BillingInfoFactory.GetBillingInfo(handler : handler,  draft :  draft,  orderId :  orderId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<BillingInfo>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo GetBillingInfo(ServiceClientMessageHandler handler, 
 		 bool? draft, string orderId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.BillingInfoClient.GetBillingInfoClient(
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
		//// BillingInfoFactory.SetBillingInfo(handler : handler,  orderId :  orderId,  billingInfo :  billingInfo,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo SetBillingInfo(ServiceClientMessageHandler handler, 
 		 string orderId, Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo billingInfo, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return SetBillingInfo(handler : handler,  orderId :  orderId,  updateMode :  null,  version :  null,  billingInfo :  billingInfo,authTicket : null, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = BillingInfoFactory.SetBillingInfo(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  billingInfo :  billingInfo, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<BillingInfo>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo SetBillingInfo(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo billingInfo, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.BillingInfoClient.SetBillingInfoClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version,  billingInfo :  billingInfo, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

