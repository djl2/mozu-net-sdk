
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DiscountResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public DiscountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discountCollection = discount.GetDiscounts(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountCollection GetDiscounts(DataViewMode dataViewMode)
		{
			return GetDiscounts(dataViewMode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discountCollection = discount.GetDiscounts(dataViewMode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountCollection GetDiscounts(DataViewMode dataViewMode, string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GetDiscountsClient(dataViewMode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discount = discount.GetDiscount(dataViewMode,  discountId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Discount GetDiscount(DataViewMode dataViewMode, int discountId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GetDiscountClient(dataViewMode,  discountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discountLocalizedContent = discount.GetDiscountContent(dataViewMode,  discountId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent GetDiscountContent(DataViewMode dataViewMode, int discountId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GetDiscountContentClient(dataViewMode,  discountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var string = discount.GenerateRandomCoupon(dataViewMode, authTicket);
		/// </code>
		/// </example>
		public virtual string GenerateRandomCoupon(DataViewMode dataViewMode, AuthTicket authTicket= null)
		{
			MozuClient<string> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.GenerateRandomCouponClient(dataViewMode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="discount"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discount = discount.CreateDiscount(dataViewMode,  discount, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Discount CreateDiscount(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Discount discount, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.CreateDiscountClient(dataViewMode,  discount, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="redemption"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Discounts.Redemption"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var redemption = discount.RedeemDiscount(dataViewMode,  redemption, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Discounts.Redemption RedeemDiscount(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Discounts.Redemption redemption, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Discounts.Redemption> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.RedeemDiscountClient(dataViewMode,  redemption, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="discount"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discount = discount.UpdateDiscount(dataViewMode,  discount,  discountId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Discount UpdateDiscount(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Discount discount, int discountId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.UpdateDiscountClient(dataViewMode,  discount,  discountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="content"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   var discountLocalizedContent = discount.UpdateDiscountContent(dataViewMode,  content,  discountId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent UpdateDiscountContent(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent content, int discountId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.UpdateDiscountContentClient(dataViewMode,  content,  discountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   discount.DeleteDiscount(dataViewMode,  discountId, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteDiscount(DataViewMode dataViewMode, int discountId, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.DeleteDiscountClient(dataViewMode,  discountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   discount.UnRedeemDiscount(dataViewMode);
		/// </code>
		/// </example>
		public virtual void UnRedeemDiscount(DataViewMode dataViewMode)
		{
			UnRedeemDiscount(dataViewMode,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="orderNumber"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var discount = new Discount();
		///   discount.UnRedeemDiscount(dataViewMode,  discountId,  orderNumber, authTicket);
		/// </code>
		/// </example>
		public virtual void UnRedeemDiscount(DataViewMode dataViewMode, int? discountId =  null, int? orderNumber =  null, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.DiscountClient.UnRedeemDiscountClient(dataViewMode,  discountId,  orderNumber, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


