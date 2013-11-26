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
	public partial class AuthTicketFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AuthTicketFactory.AuthenticateApp(handler : handler,  appAuthInfo :  appAuthInfo,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<AuthTicket>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.AppDev.AuthTicket AuthenticateApp(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.AppDev.AppAuthInfo appAuthInfo, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.AuthenticateAppClient(
				 appAuthInfo :  appAuthInfo		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AuthTicketFactory.RefreshAppAuthTicket(handler : handler,  authTicketRequest :  authTicketRequest,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<AuthTicket>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.AppDev.AuthTicket RefreshAppAuthTicket(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.AppDev.AuthTicketRequest authTicketRequest, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.RefreshAppAuthTicketClient(
				 authTicketRequest :  authTicketRequest		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AuthTicketFactory.DeleteAppAuthTicket(handler : handler,  refreshToken :  refreshToken,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<void>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteAppAuthTicket(ServiceClientMessageHandler handler, 
 		string refreshToken, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.Applications.AuthTicketClient.DeleteAppAuthTicketClient(
				 refreshToken :  refreshToken		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


