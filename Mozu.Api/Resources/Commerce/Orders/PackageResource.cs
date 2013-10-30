
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
	/// Use the packages subresource to manage the physical packages to ship for an order.
	/// </summary>
	public partial class PackageResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public PackageResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the details of a package of order items.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the package to retrieve.</param>
		/// <param name="packageId">Unique identifier of the package to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Shipping.Package"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   var package = package.GetPackage( orderId,  packageId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Shipping.Package GetPackage(string orderId, string packageId)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Shipping.Package> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PackageClient.GetPackageClient( orderId,  packageId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the package label image supplied by the carrier.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the package label to retrieve.</param>
		/// <param name="packageId">Unique identifier of the package for which to retrieve the label.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   package.GetPackageLabel( orderId,  packageId);
		/// </code>
		/// </example>
		public virtual void GetPackageLabel(string orderId, string packageId)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.PackageClient.GetPackageLabelClient( orderId,  packageId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

				/// <summary>
		/// Creates a new physical package of order items.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with this package.</param>
		/// <param name="package">Properties of the physical package of order items.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Shipping.Package"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   var package = package.CreatePackage( orderId,  pkg);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Shipping.Package CreatePackage(string orderId, Mozu.Api.Contracts.CommerceRuntime.Shipping.Package pkg)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Shipping.Package> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PackageClient.CreatePackageClient( orderId,  pkg);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Updates one or more properties of a physical package of order items.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the package to update.</param>
		/// <param name="packageId">Unique identifier of the package of order items to update.</param>
		/// <param name="package">Wrapper of properties for the package of order items to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Shipping.Package"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   var package = package.UpdatePackage( orderId,  packageId,  pkg);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Shipping.Package UpdatePackage(string orderId, string packageId, Mozu.Api.Contracts.CommerceRuntime.Shipping.Package pkg)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Shipping.Package> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PackageClient.UpdatePackageClient( orderId,  packageId,  pkg);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Removes a physical package of items from the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the package to delete.</param>
		/// <param name="packageId">Unique identifier of the package to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var package = new Package();
		///   package.DeletePackage( orderId,  packageId);
		/// </code>
		/// </example>
		public virtual void DeletePackage(string orderId, string packageId)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.PackageClient.DeletePackageClient( orderId,  packageId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

		
	}

}

