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
	/// Retrieves and modifies the products, categories, and shipping methods eligible for discounts in the form of a fixed dollar amount, percentage off a product price, or free shipping.
	/// </summary>
	public partial class DiscountTargetFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves the discount target, that is which products, categories, or shipping methods are eligible for the discount.
		/// <example> 
		///  <code> 
		/// var result = DiscountTargetFactory.GetDiscountTarget(handler : handler,  discountId :  discountId,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<DiscountTarget/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.DiscountTarget GetDiscountTarget(ServiceClientMessageHandler handler, 
 		 int discountId,  AuthTicket authTicket = null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.GetDiscountTargetClient(
				 discountId :  discountId, authTicket : authTicket, dataViewMode: dataViewMode		);
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
		/// Modifies properties of the discount target, for example, the dollar amount, or precentage off the price.
		/// <example> 
		///  <code> 
		/// var result = DiscountTargetFactory.UpdateDiscountTarget(handler : handler,  discountTarget :  discountTarget,  discountId :  discountId,  authTicket : authTicket, dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<DiscountTarget/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.DiscountTarget UpdateDiscountTarget(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.ProductAdmin.DiscountTarget discountTarget, int discountId,  AuthTicket authTicket = null, DataViewMode dataViewMode= DataViewMode.Live, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.UpdateDiscountTargetClient(
				 discountTarget :  discountTarget,  discountId :  discountId, authTicket : authTicket, dataViewMode: dataViewMode		);
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


