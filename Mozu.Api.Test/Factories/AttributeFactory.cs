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
	public partial class AttributeFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// AttributeFactory.GetAttributes(handler : handler,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode);
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeCollection GetAttributes(ServiceClientMessageHandler handler, 
 		  DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetAttributes(handler : handler,  filter :  null,  pageSize :  null,  sortBy :  null,  startIndex :  null,authTicket : null, dataViewMode: dataViewMode, 
				expectedCode: expectedCode, successCode: successCode);
		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AttributeFactory.GetAttributes(handler : handler,  filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<AttributeCollection>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeCollection GetAttributes(ServiceClientMessageHandler handler, 
 		 string filter, int? pageSize, string sortBy, int? startIndex,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.GetAttributesClient(
				 filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AttributeFactory.GetAttribute(handler : handler,  attributeFQN :  attributeFQN,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Attribute>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.Attribute GetAttribute(ServiceClientMessageHandler handler, 
 		 string attributeFQN,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.GetAttributeClient(
				 attributeFQN :  attributeFQN, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AttributeFactory.AddAttribute(handler : handler,  attribute :  attribute, authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Attribute>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.Attribute AddAttribute(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.Attribute attribute, AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.AddAttributeClient(
				 attribute :  attribute, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AttributeFactory.UpdateAttribute(handler : handler,  attributeFQN :  attributeFQN,  attribute :  attribute, authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Attribute>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.Attribute UpdateAttribute(ServiceClientMessageHandler handler, 
 		 string attributeFQN, Mozu.Api.Contracts.ProductAdmin.Attribute attribute, AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.UpdateAttributeClient(
				 attributeFQN :  attributeFQN,  attribute :  attribute, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = AttributeFactory.DeleteAttribute(handler : handler,  attributeFQN :  attributeFQN,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<void>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteAttribute(ServiceClientMessageHandler handler, 
 		string attributeFQN,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.AttributeClient.DeleteAttributeClient(
				 attributeFQN :  attributeFQN, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


