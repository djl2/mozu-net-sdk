
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use this subresource to manage notes associated with an active order.
	/// </summary>
	public partial class OrderNoteResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public OrderNoteResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of all notes for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order whose notes are retrieved.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.GetOrderNotes( orderId);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetOrderNotes(string orderId)
		{
						MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNotesClient( orderId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a specific order note from an order.
		/// </summary>
		/// <param name="noteId">Unique identifier of the note text to retrieve.</param>
		/// <param name="orderId">Unique identifier of the order note to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.GetOrderNote( noteId,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote GetOrderNote(string noteId, string orderId)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNoteClient( noteId,  orderId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Adds a note to the order. This is an internal note that the merchant can add to an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to add a note.</param>
		/// <param name="orderNote">The Unicode alphanumeric text contained in the note. Max length: 256 characters.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.CreateOrderNote( orderId,  orderNote);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote CreateOrderNote(string orderId, Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.CreateOrderNoteClient( orderId,  orderNote);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Updates a specific order note for an order.
		/// </summary>
		/// <param name="noteId">Unique identifier of the note whose text is being updated.</param>
		/// <param name="orderId">Unique identifier of the order whose note is being updated.</param>
		/// <param name="orderNote">The Unicode alphanumeric text contained in the note.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = ordernote.UpdateOrderNote( noteId,  orderId,  orderNote);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote UpdateOrderNote(string noteId, string orderId, Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.UpdateOrderNoteClient( noteId,  orderId,  orderNote);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Deletes a specific order note on an order.
		/// </summary>
		/// <param name="noteId">Unique identifier of the note text to delete.</param>
		/// <param name="orderId">Unique identifier of the order note to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   ordernote.DeleteOrderNote( noteId,  orderId);
		/// </code>
		/// </example>
		public virtual void DeleteOrderNote(string noteId, string orderId)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.DeleteOrderNoteClient( noteId,  orderId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

		
	}

}

