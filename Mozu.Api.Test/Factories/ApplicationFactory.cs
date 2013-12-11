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
	/// Use the applications subresource to update site settings for installed applications.
	/// </summary>
	public partial class ApplicationFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieve the settings of a third-party application.
		/// <example> 
		///  <code> 
		/// var result = ApplicationFactory.ThirdPartyGetApplication(handler : handler,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Application/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.SiteSettings.Application.Application ThirdPartyGetApplication(ServiceClientMessageHandler handler, 
 		  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Settings.ApplicationClient.ThirdPartyGetApplicationClient(
				 authTicket : authTicket		);
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
		/// Initializes an application with the necessary configured settings.
		/// <example> 
		///  <code> 
		/// var result = ApplicationFactory.ThirdPartyUpdateApplication(handler : handler,  application :  application, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Application/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.SiteSettings.Application.Application ThirdPartyUpdateApplication(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.SiteSettings.Application.Application application, AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Settings.ApplicationClient.ThirdPartyUpdateApplicationClient(
				 application :  application, authTicket : authTicket		);
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


