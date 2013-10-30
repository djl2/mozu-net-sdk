
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// Use the shipments resource to manage shipments of collections of packages for an order.
	/// </summary>
	public partial class ShipmentClient 	{
		
		/// <summary>
		/// Retrieves the shipment actions available for the specified order and package.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to get a list of available actions.</param>
		/// <param name="packageId">Unique identifier for the physical package associated with the order for which to get a list of available actions.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableShipmentActions( orderId,  packageId);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailableShipmentActionsClient(string orderId, string packageId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.GetAvailableShipmentActionsUrl(orderId, packageId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the order shipment specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the shipment to retrieve.</param>
		/// <param name="shipmentId">Unique identifier of the shipment to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Shipping.Shipment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetShipment( orderId,  shipmentId);
		///   var shipmentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Shipping.Shipment> GetShipmentClient(string orderId, string shipmentId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.GetShipmentUrl(orderId, shipmentId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Shipping.Shipment>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// Retrieves the available shipping methods applicable to the order. Typically used to display available shipping method options on the checkout page.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for the available shipment methods being retrieved.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Shipping.ShippingRate"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableShipmentMethods( orderId);
		///   var shippingRateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Shipping.ShippingRate>> GetAvailableShipmentMethodsClient(string orderId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.GetAvailableShipmentMethodsUrl(orderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Shipping.ShippingRate>>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

				/// <summary>
		/// Creates a shipment from one or more package associated with an order and assign a label and tracking number to an order shipment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for this shipment.</param>
		/// <param name="packageIds">List of unique identifiers for each package associated with this shipment. Not all packages must belong to the same shipment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Shipping.Package"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePackageShipments( orderId,  packageIds);
		///   var packageClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Shipping.Package>> CreatePackageShipmentsClient(string orderId, List<string> packageIds)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.CreatePackageShipmentsUrl(orderId);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Shipping.Package>>().WithVerb(verb).WithResourceUrl(url).WithBody<List<string>>(packageIds);
		return mozuClient;

		}

		/// <summary>
		/// Sets the shipment action to "Ship." To ship an order, the order must have a customer name, the "Open" or "OpenAndProcessing" status, full shipping address, and shipping method. Shipping all packages associated with shipments for an order will complete a paid order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the shipment for which to perform the action.</param>
		/// <param name="action">The action to perform for the order shipment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformShipmentAction( orderId,  action);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> PerformShipmentActionClient(string orderId, Mozu.Api.Contracts.CommerceRuntime.Shipping.ShipmentAction action)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.PerformShipmentActionUrl(orderId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Shipping.ShipmentAction>(action);
		return mozuClient;

		}

						/// <summary>
		/// Cancels a shipment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order to cancel shipment.</param>
		/// <param name="shipmentId">Unique identifier of the shipment to cancel.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteShipment( orderId,  shipmentId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteShipmentClient(string orderId, string shipmentId)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ShipmentUrl.DeleteShipmentUrl(orderId, shipmentId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		
	}

}

