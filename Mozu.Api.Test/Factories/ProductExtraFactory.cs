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
	public partial class ProductExtraFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductExtraFactory.GetExtras(handler : handler,  productCode :  productCode,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<List<ProductExtra>>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.ProductAdmin.ProductExtra> GetExtras(ServiceClientMessageHandler handler, 
 		 string productCode,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.GetExtrasClient(
				 productCode :  productCode, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductExtraFactory.GetExtra(handler : handler,  attributeFQN :  attributeFQN,  productCode :  productCode,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<ProductExtra>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductExtra GetExtra(ServiceClientMessageHandler handler, 
 		 string attributeFQN, string productCode,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.GetExtraClient(
				 attributeFQN :  attributeFQN,  productCode :  productCode, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductExtraFactory.AddExtra(handler : handler,  productCode :  productCode,  productExtra :  productExtra, authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<ProductExtra>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductExtra AddExtra(ServiceClientMessageHandler handler, 
 		 string productCode, Mozu.Api.Contracts.ProductAdmin.ProductExtra productExtra, AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.AddExtraClient(
				 productCode :  productCode,  productExtra :  productExtra, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductExtraFactory.UpdateExtra(handler : handler,  attributeFQN :  attributeFQN,  productCode :  productCode,  productExtra :  productExtra, authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<ProductExtra>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.ProductExtra UpdateExtra(ServiceClientMessageHandler handler, 
 		 string attributeFQN, string productCode, Mozu.Api.Contracts.ProductAdmin.ProductExtra productExtra, AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.UpdateExtraClient(
				 attributeFQN :  attributeFQN,  productCode :  productCode,  productExtra :  productExtra, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = ProductExtraFactory.DeleteExtra(handler : handler,  attributeFQN :  attributeFQN,  productCode :  productCode,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<void>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteExtra(ServiceClientMessageHandler handler, 
 		string attributeFQN, string productCode,  AuthTicket authTicket= null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductExtraClient.DeleteExtraClient(
				 attributeFQN :  attributeFQN,  productCode :  productCode, authTicket : authTicket, dataViewMode: dataViewMode		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}


