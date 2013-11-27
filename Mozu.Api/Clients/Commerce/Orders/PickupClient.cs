
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


namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// 
	/// </summary>
	public partial class PickupClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="pickupId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPickup( orderId,  pickupId, authTicket);
		///   var pickupClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> GetPickupClient(string orderId, string pickupId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PickupUrl.GetPickupUrl(orderId, pickupId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="pickupId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailablePickupFulfillmentActions( orderId,  pickupId, authTicket);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailablePickupFulfillmentActionsClient(string orderId, string pickupId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PickupUrl.GetAvailablePickupFulfillmentActionsUrl(orderId, pickupId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="pickup"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePickup( pickup,  orderId, authTicket);
		///   var pickupClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> CreatePickupClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PickupUrl.CreatePickupUrl(orderId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup>(pickup);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="pickupId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="pickup"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePickup( pickup,  orderId,  pickupId, authTicket);
		///   var pickupClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> UpdatePickupClient(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, string pickupId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PickupUrl.UpdatePickupUrl(orderId, pickupId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup>(pickup);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="pickupId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeletePickup( orderId,  pickupId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeletePickupClient(string orderId, string pickupId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.PickupUrl.DeletePickupUrl(orderId, pickupId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


