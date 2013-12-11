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
	/// Get the product category hierarchy as it appears to shoppers who are browsing the storefront. The hierarchy can be returned as a flat list or as a category tree.
	/// </summary>
	public partial class StorefrontCategoryFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// <example> 
		///  <code> 
		/// var result = CategoryFactory.GetCategories(handler : handler,  filter :  filter,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CategoryPagedCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection GetCategories(ServiceClientMessageHandler handler, 
 		 string filter = null, int? startIndex = null, int? pageSize = null, string sortBy = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoriesClient(
				 filter :  filter,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy, authTicket : authTicket		);
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
		/// Retrieves the details of a single category.
		/// <example> 
		///  <code> 
		/// var result = CategoryFactory.GetCategory(handler : handler,  categoryId :  categoryId,  allowInactive :  allowInactive,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<Category/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.Category GetCategory(ServiceClientMessageHandler handler, 
 		 int categoryId, bool? allowInactive = null,  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryClient(
				 categoryId :  categoryId,  allowInactive :  allowInactive, authTicket : authTicket		);
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
		/// Retrieves the list of product categories that appear on the storefront organized in a hierarchical format. Hidden categories do not appear in the list.
		/// <example> 
		///  <code> 
		/// var result = CategoryFactory.GetCategoryTree(handler : handler,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<CategoryCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductRuntime.CategoryCollection GetCategoryTree(ServiceClientMessageHandler handler, 
 		  AuthTicket authTicket = null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryTreeClient(
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
  

	}

}


