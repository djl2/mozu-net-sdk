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
	public partial class ProductTypePropertyFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductTypePropertyFactory.GetProperties(handler : handler,  productTypeId :  productTypeId,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<AttributeInProductType>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetProperties(ServiceClientMessageHandler handler, 
 		 int productTypeId,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertiesClient(
				 productTypeId :  productTypeId, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductTypePropertyFactory.GetProperty(handler : handler,  attributeFQN :  attributeFQN,  productTypeId :  productTypeId,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<AttributeInProductType>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeInProductType GetProperty(ServiceClientMessageHandler handler, 
 		 string attributeFQN, int productTypeId,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertyClient(
				 attributeFQN :  attributeFQN,  productTypeId :  productTypeId, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductTypePropertyFactory.AddProperty(handler : handler,  productTypeId :  productTypeId,  attributeInProductType :  attributeInProductType, authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<AttributeInProductType>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeInProductType AddProperty(ServiceClientMessageHandler handler, 
 		 int productTypeId, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.AddPropertyClient(
				 productTypeId :  productTypeId,  attributeInProductType :  attributeInProductType, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductTypePropertyFactory.UpdateProperty(handler : handler,  attributeFQN :  attributeFQN,  productTypeId :  productTypeId,  attributeInProductType :  attributeInProductType, authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<AttributeInProductType>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeInProductType UpdateProperty(ServiceClientMessageHandler handler, 
 		 string attributeFQN, int productTypeId, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.UpdatePropertyClient(
				 attributeFQN :  attributeFQN,  productTypeId :  productTypeId,  attributeInProductType :  attributeInProductType, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductTypePropertyFactory.DeleteProperty(handler : handler,  attributeFQN :  attributeFQN,  productTypeId :  productTypeId,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<void>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteProperty(ServiceClientMessageHandler handler, 
 		string attributeFQN, int productTypeId,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.DeletePropertyClient(
				 attributeFQN :  attributeFQN,  productTypeId :  productTypeId, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

