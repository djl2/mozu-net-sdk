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
	public partial class LocationTypeFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = LocationTypeFactory.GetLocationTypes(handler : handler,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<LocationType>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.Location.LocationType> GetLocationTypes(ServiceClientMessageHandler handler, 
 		  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Location.Admin.LocationTypeClient.GetLocationTypesClient(
				 authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = LocationTypeFactory.GetLocationType(handler : handler,  locationTypeCode :  locationTypeCode,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<LocationType>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Location.LocationType GetLocationType(ServiceClientMessageHandler handler, 
 		 string locationTypeCode,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Location.Admin.LocationTypeClient.GetLocationTypeClient(
				 locationTypeCode :  locationTypeCode, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = LocationTypeFactory.AddLocationType(handler : handler,  locationType :  locationType, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<LocationType>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Location.LocationType AddLocationType(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.Location.LocationType locationType, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Location.Admin.LocationTypeClient.AddLocationTypeClient(
				 locationType :  locationType, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = LocationTypeFactory.UpdateLocationType(handler : handler,  locationTypeCode :  locationTypeCode,  locationType :  locationType, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<LocationType>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Location.LocationType UpdateLocationType(ServiceClientMessageHandler handler, 
 		 string locationTypeCode, Mozu.Api.Contracts.Location.LocationType locationType, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Location.Admin.LocationTypeClient.UpdateLocationTypeClient(
				 locationTypeCode :  locationTypeCode,  locationType :  locationType, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = LocationTypeFactory.DeleteLocationType(handler : handler,  locationTypeCode :  locationTypeCode,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<void>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteLocationType(ServiceClientMessageHandler handler, 
 		string locationTypeCode,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Location.Admin.LocationTypeClient.DeleteLocationTypeClient(
				 locationTypeCode :  locationTypeCode, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


