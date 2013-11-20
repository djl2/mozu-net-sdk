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
	/// Use the tenant data resource to store tenant-level information required for a third-party application in the Mozu database.
	/// </summary>
	public partial class TenantDataFactory : BaseDataFactory
	{

	/// <summary> 
		/// Retrieves the value of a record in the Mozu database.
		/// TenantDataFactory.GetDBValue(handler : handler,  dbEntryQuery :  dbEntryQuery,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<string>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static string GetDBValue(ServiceClientMessageHandler handler, 
 		 string dbEntryQuery, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.TenantDataClient.GetDBValueClient(
				 dbEntryQuery :  dbEntryQuery		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Creates a new record in the Mozu database based on the information supplied in the request.
		/// TenantDataFactory.CreateDBValue(handler : handler,  dbEntryQuery :  dbEntryQuery,  value :  value,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void CreateDBValue(ServiceClientMessageHandler handler, 
 		string dbEntryQuery, string value, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.TenantDataClient.CreateDBValueClient(
				 dbEntryQuery :  dbEntryQuery,  value :  value		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Updates a record in the Mozu database based on the information supplied in the request.
		/// TenantDataFactory.UpdateDBValue(handler : handler,  dbEntryQuery :  dbEntryQuery,  value :  value,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void UpdateDBValue(ServiceClientMessageHandler handler, 
 		string dbEntryQuery, string value, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.TenantDataClient.UpdateDBValueClient(
				 dbEntryQuery :  dbEntryQuery,  value :  value		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Removes a previously defined record in the Mozu database.
		/// TenantDataFactory.DeleteDBValue(handler : handler,  dbEntryQuery :  dbEntryQuery,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void DeleteDBValue(ServiceClientMessageHandler handler, 
 		string dbEntryQuery, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.TenantDataClient.DeleteDBValueClient(
				 dbEntryQuery :  dbEntryQuery		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		
	}

}


