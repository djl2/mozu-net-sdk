
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
	/// Use the Fulfillment Information resource to manage shipping or pickup information for orders.
	/// </summary>
	public partial class FulfillmentInfoResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public FulfillmentInfoResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of the fulfillment information for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentinfo = new FulfillmentInfo();
		///   var fulfillmentInfo = fulfillmentinfo.GetFulfillmentInfo( orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo GetFulfillmentInfo(string orderId)
		{
			return GetFulfillmentInfo( orderId,  null, null);
		}

		/// <summary>
		/// Retrieves a list of the fulfillment information for the specified order.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order's fulfillment information, which might include uncommitted changes.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentinfo = new FulfillmentInfo();
		///   var fulfillmentInfo = fulfillmentinfo.GetFulfillmentInfo( orderId,  draft, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo GetFulfillmentInfo(string orderId, bool? draft =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.FulfillmentInfoClient.GetFulfillmentInfoClient( orderId,  draft, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of fulfillment information for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="fulfillmentInfo">Array list of fulfillment information associated with an order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentinfo = new FulfillmentInfo();
		///   var fulfillmentInfo = fulfillmentinfo.SetFulFillmentInfo( fulfillmentInfo,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo SetFulFillmentInfo(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo fulfillmentInfo, string orderId)
		{
			return SetFulFillmentInfo( fulfillmentInfo,  orderId,  null,  null, null);
		}

		/// <summary>
		/// Updates one or more properties of fulfillment information for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="updateMode">Specifies whether to set the fulfillment information by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="fulfillmentInfo">Array list of fulfillment information associated with an order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var fulfillmentinfo = new FulfillmentInfo();
		///   var fulfillmentInfo = fulfillmentinfo.SetFulFillmentInfo( fulfillmentInfo,  orderId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo SetFulFillmentInfo(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo fulfillmentInfo, string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.FulfillmentInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.FulfillmentInfoClient.SetFulFillmentInfoClient( fulfillmentInfo,  orderId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


