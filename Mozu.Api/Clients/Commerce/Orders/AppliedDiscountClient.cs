
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
	/// Use this subresource to apply coupons to or remove coupons from an order based on a supplied coupon code.
	/// </summary>
	public partial class AppliedDiscountClient 	{
		
						/// <summary>
		/// Apply a coupon to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order to associate the coupon. System-supplied and read-only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ApplyCoupon( couponCode,  orderId);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ApplyCouponClient(string couponCode, string orderId)
		{
			return ApplyCouponClient( couponCode,  orderId,  null,  null);
		}

		/// <summary>
		/// Apply a coupon to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order to associate the coupon. System-supplied and read-only.</param>
		/// <param name="updateMode">Specifies whether to apply the coupon by updating the original order, updating the order in draft mode, or updating the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version">If applicable, the version of the order or order draft to which to apply the coupon.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ApplyCoupon( couponCode,  orderId,  updateMode,  version);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> ApplyCouponClient(string couponCode, string orderId, string updateMode, string version)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.AppliedDiscountUrl.ApplyCouponUrl(couponCode, orderId, updateMode, version);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

				/// <summary>
		/// Removes a coupon previously applied to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order with the coupon to remove.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveCoupon( couponCode,  orderId);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> RemoveCouponClient(string couponCode, string orderId)
		{
			return RemoveCouponClient( couponCode,  orderId,  null,  null);
		}

		/// <summary>
		/// Removes a coupon previously applied to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order with the coupon to remove.</param>
		/// <param name="updateMode">Specifies whether to remove the coupon by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version">If applicable, the version of the order or order draft from which to remove the coupon.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveCoupon( couponCode,  orderId,  updateMode,  version);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> RemoveCouponClient(string couponCode, string orderId, string updateMode, string version)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.AppliedDiscountUrl.RemoveCouponUrl(couponCode, orderId, updateMode, version);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// Removes all coupons previously applied to the order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the coupons to remove.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveCoupons( orderId);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> RemoveCouponsClient(string orderId)
		{
			return RemoveCouponsClient( orderId,  null,  null);
		}

		/// <summary>
		/// Removes all coupons previously applied to the order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the coupons to remove.</param>
		/// <param name="updateMode">Specifies whether to remove coupons by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version">If applicable, the version of the order or order draft from which to remove coupons.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RemoveCoupons( orderId,  updateMode,  version);
		///   var orderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> RemoveCouponsClient(string orderId, string updateMode, string version)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.AppliedDiscountUrl.RemoveCouponsUrl(orderId, updateMode, version);
			const string verb = "DELETE";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		
	}

}

