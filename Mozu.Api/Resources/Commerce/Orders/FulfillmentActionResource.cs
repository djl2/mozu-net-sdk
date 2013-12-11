
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
using Mozu.Api.Security;


namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Fulfillment resource to manage shipments or pickups of collections of packages for an order.
	/// </summary>
	public partial class FulfillmentActionResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public FulfillmentActionResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Sets the fulfillment action to "Ship" or "PickUp". To ship an order or prepare it for in-store pickup, the order must have a customer name, the "Open" or "OpenAndProcessing" status. To ship the order, it must also have the full shipping address and shipping method. Shipping all packages or picking up all pickups for an order will complete a paid order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to perform the fulfillment action.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action">The action to perform for the order fulfillment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentaction = new FulfillmentAction();
		///   var order = fulfillmentaction.PerformFulfillmentAction( action,  orderId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order PerformFulfillmentAction(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentAction action, string orderId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.FulfillmentActionClient.PerformFulfillmentActionClient( action,  orderId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


