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
	public partial class CustomerAuthTicketFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		/// var result = CustomerAuthTicketFactory.CreateUserAuthTicket(handler : handler,  userAuthInfo :  userAuthInfo, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CustomerAuthTicket/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerAuthTicket CreateUserAuthTicket(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.Customer.CustomerUserAuthInfo userAuthInfo, AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAuthTicketClient.CreateUserAuthTicketClient(
				 userAuthInfo :  userAuthInfo, authTicket : authTicket		);
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
		/// 
		/// <example> 
		///  <code> 
		/// var result = CustomerAuthTicketFactory.RefreshUserAuthTicket(handler : handler,  refreshToken :  refreshToken,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CustomerAuthTicket/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerAuthTicket RefreshUserAuthTicket(ServiceClientMessageHandler handler, 
 		 string refreshToken,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAuthTicketClient.RefreshUserAuthTicketClient(
				 refreshToken :  refreshToken, authTicket : authTicket		);
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


