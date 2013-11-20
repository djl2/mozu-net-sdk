
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


namespace Mozu.Api.Clients.Commerce.Returns
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShipmentClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId"></param>
		/// <param name="shipmentId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetShipment( returnId,  shipmentId, authTicket);
		///   var shipmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment> GetShipmentClient(string returnId, string shipmentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.ShipmentUrl.GetShipmentUrl(returnId, shipmentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="packageIds"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackageShipments( packageIds,  returnId, authTicket);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>> CreatePackageShipmentsClient(List<string> packageIds, string returnId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.ShipmentUrl.CreatePackageShipmentsUrl(returnId);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Package>>().WithVerb(verb).WithResourceUrl(url).WithBody(packageIds);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

						/// <summary>
		/// 
		/// </summary>
		/// <param name="returnId"></param>
		/// <param name="shipmentId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteShipment( returnId,  shipmentId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteShipmentClient(string returnId, string shipmentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Returns.ShipmentUrl.DeleteShipmentUrl(returnId, shipmentId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


