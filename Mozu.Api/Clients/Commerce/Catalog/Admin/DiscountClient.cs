
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// Define and manage discounts to apply to products, product categories, or orders. The discounts can be a specified amount off the price, percentage off the price, or for free shipping. Create a coupon code that shoppers can use to redeem the discount.
	/// </summary>
	public partial class DiscountClient 	{
		
		/// <summary>
		/// Retrieves a list of discounts according to any specified filter criteria and sort options.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscounts(dataViewMode);
		///   var discountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountCollection> GetDiscountsClient(DataViewMode dataViewMode)
		{
			return GetDiscountsClient(dataViewMode,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of discounts according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscounts(dataViewMode,  startIndex,  pageSize,  sortBy,  filter);
		///   var discountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountCollection> GetDiscountsClient(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GetDiscountsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a single discount.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscount(dataViewMode,  discountId);
		///   var discountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> GetDiscountClient(DataViewMode dataViewMode, int discountId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GetDiscountUrl(discountId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the localized content specified for the specified discount.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDiscountContent(dataViewMode,  discountId);
		///   var discountLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> GetDiscountContentClient(DataViewMode dataViewMode, int discountId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GetDiscountContentUrl(discountId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Generates a random code for a coupon.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GenerateRandomCoupon(dataViewMode);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<string> GenerateRandomCouponClient(DataViewMode dataViewMode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.GenerateRandomCouponUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<string>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a discount.
		/// </summary>
		/// <param name="discount">Properties of the discount to create. Required properties: Content.Name, AmountType, StartDate, and Target.Type.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDiscount(dataViewMode,  discount);
		///   var discountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> CreateDiscountClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Discount discount)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.CreateDiscountUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Discount>(discount)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Modifies a discount.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <param name="discount">Properties of the discount to update. Required properties: Content.Name, AmountType, StartDate, and Target.Type. Any unspecified properties are set to null and boolean variables are set to false.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.Discount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDiscount(dataViewMode,  discount,  discountId);
		///   var discountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount> UpdateDiscountClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Discount discount, int discountId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.UpdateDiscountUrl(discountId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.Discount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.Discount>(discount)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Modifies the localized content for the specified discount. Rename the discount without modifying any other discount properties.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <param name="content">New Name and/or LocaleCode. Properties of the content to update. Required property: Name.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDiscountContent(dataViewMode,  content,  discountId);
		///   var discountLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent> UpdateDiscountContentClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent content, int discountId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.UpdateDiscountContentUrl(discountId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.DiscountLocalizedContent>(content)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes a discount specified by its discount ID.
		/// </summary>
		/// <param name="discountId">Unique identifier of the discount. System-supplied and read-only.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDiscount(dataViewMode,  discountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDiscountClient(DataViewMode dataViewMode, int discountId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.DiscountUrl.DeleteDiscountUrl(discountId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


