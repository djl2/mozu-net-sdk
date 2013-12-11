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
	/// Use the Developer Accounts resource to retrieve details about the developer account a company uses to test applications and themes.
	/// </summary>
	public partial class DeveloperAccountFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves the details of the developer account specified in the request.
		/// <example> 
		///  <code> 
		/// var result = DeveloperAccountFactory.GetDeveloperAccount(handler : handler,  accountId :  accountId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<DeveloperAccount/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.AppDev.DeveloperAccount GetDeveloperAccount(ServiceClientMessageHandler handler, 
 		 int? accountId = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Platform.Developer.DeveloperAccountClient.GetDeveloperAccountClient(
				 accountId :  accountId, authTicket : authTicket		);
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


