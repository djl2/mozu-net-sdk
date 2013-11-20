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
using Newtonsoft.Json;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// 
	/// </summary>
	public partial class FulfillmentInfoFactory : BaseDataFactory
	{

	/// <summary> 
		/// 
		/// FulfillmentInfoFactory.GetFulfillmentInfo(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo GetFulfillmentInfo(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetFulfillmentInfo(handler : handler,  draft :  null,  orderId :  orderId, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// 
		/// FulfillmentInfoFactory.GetFulfillmentInfo(handler : handler,  draft :  draft,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<FulfillmentInfo>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo GetFulfillmentInfo(ServiceClientMessageHandler handler, 
 		 bool? draft, string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.FulfillmentInfoClient.GetFulfillmentInfoClient(
				 draft :  draft,  orderId :  orderId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

				/// <summary> 
		/// 
		/// FulfillmentInfoFactory.SetFulFillmentInfo(handler : handler,  orderId :  orderId,  fulfillmentInfo :  fulfillmentInfo,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo SetFulFillmentInfo(ServiceClientMessageHandler handler, 
 		 string orderId, Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo fulfillmentInfo, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return SetFulFillmentInfo(handler : handler,  orderId :  orderId,  updateMode :  null,  version :  null,  fulfillmentInfo :  fulfillmentInfo, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// 
		/// FulfillmentInfoFactory.SetFulFillmentInfo(handler : handler,  orderId :  orderId,  updateMode :  updateMode,  version :  version,  fulfillmentInfo :  fulfillmentInfo,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<FulfillmentInfo>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo SetFulFillmentInfo(ServiceClientMessageHandler handler, 
 		 string orderId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo fulfillmentInfo, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.FulfillmentInfoClient.SetFulFillmentInfoClient(
				 orderId :  orderId,  updateMode :  updateMode,  version :  version,  fulfillmentInfo :  fulfillmentInfo		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			
	}

}


