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
	public partial class DeveloperAccountFactory : BaseDataFactory
	{

	/// <summary> 
		/// 
		/// DeveloperAccountFactory.GetDeveloperAccount(handler : handler,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static Mozu.Api.Contracts.AppDev.DeveloperAccount GetDeveloperAccount(ServiceClientMessageHandler handler, 
 		 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetDeveloperAccount(handler : handler,  accountId :  null, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// 
		/// DeveloperAccountFactory.GetDeveloperAccount(handler : handler,  accountId :  accountId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<DeveloperAccount>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.AppDev.DeveloperAccount GetDeveloperAccount(ServiceClientMessageHandler handler, 
 		 int? accountId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.Developer.DeveloperAccountClient.GetDeveloperAccountClient(
				 accountId :  accountId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

					
	}

}


