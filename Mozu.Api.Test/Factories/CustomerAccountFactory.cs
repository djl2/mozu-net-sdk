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
using Newtonsoft.Json;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Create, view, update, and delete a contact in a customer account. A customer account may have multiple contacts for billing or shipping addresses. Each contact may also list any groups to which the contact belongs and whether the contact accepts marketing material such as newsletters or email offers.
	/// </summary>
	public partial class CustomerAccountFactory : BaseDataFactory
	{

	/// <summary> 
		/// Retrieves a list of customer accounts.
		/// CustomerAccountFactory.GetAccounts(handler : handler,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerAccountCollection GetAccounts(ServiceClientMessageHandler handler, 
 		 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetAccounts(handler : handler,  fields :  null,  filter :  null,  pageSize :  null,  q :  null,  qLimit :  null,  sortBy :  null,  startIndex :  null, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// Retrieves a list of customer accounts.
		/// CustomerAccountFactory.GetAccounts(handler : handler,  fields :  fields,  filter :  filter,  pageSize :  pageSize,  q :  q,  qLimit :  qLimit,  sortBy :  sortBy,  startIndex :  startIndex,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<CustomerAccountCollection>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerAccountCollection GetAccounts(ServiceClientMessageHandler handler, 
 		 string fields, string filter, int? pageSize, string q, int? qLimit, string sortBy, int? startIndex, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetAccountsClient(
				 fields :  fields,  filter :  filter,  pageSize :  pageSize,  q :  q,  qLimit :  qLimit,  sortBy :  sortBy,  startIndex :  startIndex		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		/// <summary> 
		/// Retrieve details of a customer account.
		/// CustomerAccountFactory.GetAccount(handler : handler,  accountId :  accountId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<CustomerAccount>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerAccount GetAccount(ServiceClientMessageHandler handler, 
 		 int accountId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetAccountClient(
				 accountId :  accountId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		/// <summary> 
		/// 
		/// CustomerAccountFactory.GetInStockNotification(handler : handler,  accountId :  accountId,  inStockNotificationSubscriptionId :  inStockNotificationSubscriptionId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<CustomerInStockNotificationSubscription>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerInStockNotificationSubscription GetInStockNotification(ServiceClientMessageHandler handler, 
 		 int accountId, int inStockNotificationSubscriptionId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetInStockNotificationClient(
				 accountId :  accountId,  inStockNotificationSubscriptionId :  inStockNotificationSubscriptionId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		/// <summary> 
		/// 
		/// CustomerAccountFactory.GetInStockNotifications(handler : handler,  accountId :  accountId,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerInStockNotificationSubscriptionCollection GetInStockNotifications(ServiceClientMessageHandler handler, 
 		 int accountId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return GetInStockNotifications(handler : handler,  accountId :  accountId,  filter :  null,  pageSize :  null,  sortBy :  null,  startIndex :  null, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// 
		/// CustomerAccountFactory.GetInStockNotifications(handler : handler,  accountId :  accountId,  filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<CustomerInStockNotificationSubscriptionCollection>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerInStockNotificationSubscriptionCollection GetInStockNotifications(ServiceClientMessageHandler handler, 
 		 int accountId, string filter, int? pageSize, string sortBy, int? startIndex, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.GetInStockNotificationsClient(
				 accountId :  accountId,  filter :  filter,  pageSize :  pageSize,  sortBy :  sortBy,  startIndex :  startIndex		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Creates a new customer account.
		/// CustomerAccountFactory.AddAccount(handler : handler,  account :  account,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<CustomerAccount>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerAccount AddAccount(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.Customer.CustomerAccount account, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddAccountClient(
				 account :  account		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		/// <summary> 
		/// 
		/// CustomerAccountFactory.AddInStockNotification(handler : handler,  accountId :  accountId,  inStockNotificationSubscription :  inStockNotificationSubscription,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<CustomerInStockNotificationSubscription>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerInStockNotificationSubscription AddInStockNotification(ServiceClientMessageHandler handler, 
 		 int accountId, Mozu.Api.Contracts.Customer.CustomerInStockNotificationSubscription inStockNotificationSubscription, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.AddInStockNotificationClient(
				 accountId :  accountId,  inStockNotificationSubscription :  inStockNotificationSubscription		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Updates a customer account.
		/// CustomerAccountFactory.UpdateAccount(handler : handler,  accountId :  accountId,  account :  account,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<CustomerAccount>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CustomerAccount UpdateAccount(ServiceClientMessageHandler handler, 
 		 int accountId, Mozu.Api.Contracts.Customer.CustomerAccount account, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.UpdateAccountClient(
				 accountId :  accountId,  account :  account		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Deletes a customer account. A customer account cannot be deleted if any orders exist, past or present.
		/// CustomerAccountFactory.DeleteAccount(handler : handler,  accountId :  accountId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void DeleteAccount(ServiceClientMessageHandler handler, 
 		int accountId, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.DeleteAccountClient(
				 accountId :  accountId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		/// <summary> 
		/// 
		/// CustomerAccountFactory.DeleteInStockNotificationSubscription(handler : handler,  accountId :  accountId,  inStockNotificationSubscriptionId :  inStockNotificationSubscriptionId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void DeleteInStockNotificationSubscription(ServiceClientMessageHandler handler, 
 		int accountId, int inStockNotificationSubscriptionId, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.CustomerAccountClient.DeleteInStockNotificationSubscriptionClient(
				 accountId :  accountId,  inStockNotificationSubscriptionId :  inStockNotificationSubscriptionId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		
	}

}


