
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
	/// Use this subresource to apply coupons to or remove coupons from an order based on a supplied coupon code.
	/// </summary>
	public partial class AppliedDiscountResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public AppliedDiscountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
						/// <summary>
		/// Apply a coupon to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order to associate the coupon. System-supplied and read-only.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var order = applieddiscount.ApplyCoupon( couponCode,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyCoupon(string couponCode, string orderId)
		{
			return ApplyCoupon( couponCode,  orderId,  null,  null, null);
		}

		/// <summary>
		/// Apply a coupon to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order to associate the coupon. System-supplied and read-only.</param>
		/// <param name="updateMode">Specifies whether to apply the coupon by updating the original order, updating the order in draft mode, or updating the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var order = applieddiscount.ApplyCoupon( couponCode,  orderId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyCoupon(string couponCode, string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.AppliedDiscountClient.ApplyCouponClient( couponCode,  orderId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Removes a coupon previously applied to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order with the coupon to remove.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var order = applieddiscount.RemoveCoupon( couponCode,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveCoupon(string couponCode, string orderId)
		{
			return RemoveCoupon( couponCode,  orderId,  null,  null, null);
		}

		/// <summary>
		/// Removes a coupon previously applied to the order.
		/// </summary>
		/// <param name="couponCode"></param>
		/// <param name="orderId">Unique identifier of the order with the coupon to remove.</param>
		/// <param name="updateMode">Specifies whether to remove the coupon by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var order = applieddiscount.RemoveCoupon( couponCode,  orderId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveCoupon(string couponCode, string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.AppliedDiscountClient.RemoveCouponClient( couponCode,  orderId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Removes all coupons previously applied to the order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the coupons to remove.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var order = applieddiscount.RemoveCoupons( orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveCoupons(string orderId)
		{
			return RemoveCoupons( orderId,  null,  null, null);
		}

		/// <summary>
		/// Removes all coupons previously applied to the order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the coupons to remove.</param>
		/// <param name="updateMode">Specifies whether to remove coupons by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var order = applieddiscount.RemoveCoupons( orderId,  updateMode,  version, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveCoupons(string orderId, string updateMode =  null, string version =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.AppliedDiscountClient.RemoveCouponsClient( orderId,  updateMode,  version, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		
	}

}


