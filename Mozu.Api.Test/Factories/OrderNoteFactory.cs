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
	/// Use this subresource to manage notes associated with an active order.
	/// </summary>
	public partial class OrderNoteFactory : BaseDataFactory
	{

	/// <summary> 
		/// Retrieves a list of all notes for an order.
		/// OrderNoteFactory.GetOrderNotes(handler : handler,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<List<OrderNote>>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetOrderNotes(ServiceClientMessageHandler handler, 
 		 string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNotesClient(
				 orderId :  orderId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		/// <summary> 
		/// Retrieves a specific order note from an order.
		/// OrderNoteFactory.GetOrderNote(handler : handler,  noteId :  noteId,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<OrderNote>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote GetOrderNote(ServiceClientMessageHandler handler, 
 		 string noteId, string orderId, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNoteClient(
				 noteId :  noteId,  orderId :  orderId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Adds a note to the order. This is an internal note that the merchant can add to an order.
		/// OrderNoteFactory.CreateOrderNote(handler : handler,  orderId :  orderId,  orderNote :  orderNote,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<OrderNote>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote CreateOrderNote(ServiceClientMessageHandler handler, 
 		 string orderId, Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.CreateOrderNoteClient(
				 orderId :  orderId,  orderNote :  orderNote		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Updates a specific order note for an order.
		/// OrderNoteFactory.UpdateOrderNote(handler : handler,  noteId :  noteId,  orderId :  orderId,  orderNote :  orderNote,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<OrderNote>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote UpdateOrderNote(ServiceClientMessageHandler handler, 
 		 string noteId, string orderId, Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.UpdateOrderNoteClient(
				 noteId :  noteId,  orderId :  orderId,  orderNote :  orderNote		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Deletes a specific order note on an order.
		/// OrderNoteFactory.DeleteOrderNote(handler : handler,  noteId :  noteId,  orderId :  orderId,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void DeleteOrderNote(ServiceClientMessageHandler handler, 
 		string noteId, string orderId, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.DeleteOrderNoteClient(
				 noteId :  noteId,  orderId :  orderId		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		
	}

}


