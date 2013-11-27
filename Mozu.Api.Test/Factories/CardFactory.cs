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
	public partial class CardFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = CardFactory.GetAccountCards(handler : handler,  accountId :  accountId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<CardCollection>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Customer.CardCollection GetAccountCards(ServiceClientMessageHandler handler, 
 		 int accountId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.GetAccountCardsClient(
				 accountId :  accountId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = CardFactory.AddAccountCard(handler : handler,  accountId :  accountId,  card :  card, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Card>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Customer.Card AddAccountCard(ServiceClientMessageHandler handler, 
 		 int accountId, Mozu.Api.Contracts.Customer.Card card, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.Created, int successCode = (int)HttpStatusCode.Created)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.AddAccountCardClient(
				 accountId :  accountId,  card :  card, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = CardFactory.UpdateAccountCard(handler : handler,  accountId :  accountId,  card :  card, authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<Card>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.Customer.Card UpdateAccountCard(ServiceClientMessageHandler handler, 
 		 int accountId, Mozu.Api.Contracts.Customer.Card card, AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.UpdateAccountCardClient(
				 accountId :  accountId,  card :  card, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  
		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		//// var result = CardFactory.DeleteAccountCard(handler : handler,  accountId :  accountId,  cardId :  cardId,  authTicket : authTicket,  expectedCode: expectedCode, successCode: successCode); 
		//// var optionalCasting = ConvertClass<void>(result); 
		//// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static void DeleteAccountCard(ServiceClientMessageHandler handler, 
 		int accountId, string cardId,  AuthTicket authTicket= null, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.DeleteAccountCardClient(
				 accountId :  accountId,  cardId :  cardId, authTicket : authTicket		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

