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
	public partial class AttributeTypeRuleFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// AttributeTypeRuleFactory.GetAttributeTypeRules(handler : handler,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection GetAttributeTypeRules(ServiceClientMessageHandler handler, 
 		  DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetAttributeTypeRules(handler : handler,  filter :  null,  pageSize :  null,  sortBy :  null,  startIndex :  null,authTicket : null, dataViewMode: dataViewMode, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AttributeTypeRuleFactory.GetAttributeTypeRules(handler : handler,  filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<AttributeTypeRuleCollection>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection GetAttributeTypeRules(ServiceClientMessageHandler handler, 
 		 string filter, int? pageSize, string sortBy, int? startIndex,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeTypeRuleClient.GetAttributeTypeRulesClient(
				 filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

