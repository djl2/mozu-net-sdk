
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Orders
{
	public partial class AppliedDiscountUrl : BaseUrl
	{

						/// <summary>
        /// Get Resource Url for ApplyCoupon
        /// </summary>
        /// <param name="couponCode"></param>
        /// <param name="orderId">Unique identifier of the order to associate the coupon. System-supplied and read-only.</param>
        /// <param name="updateMode">Specifies whether to apply the coupon by updating the original order, updating the order in draft mode, or updating the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft to which to apply the coupon.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string ApplyCouponUrl(string couponCode, string orderId, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/coupons/{couponCode}?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "couponCode", couponCode);
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

				/// <summary>
        /// Get Resource Url for RemoveCoupon
        /// </summary>
        /// <param name="couponCode"></param>
        /// <param name="orderId">Unique identifier of the order with the coupon to remove.</param>
        /// <param name="updateMode">Specifies whether to remove the coupon by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft from which to remove the coupon.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string RemoveCouponUrl(string couponCode, string orderId, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/coupons/{couponcode}?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "couponCode", couponCode);
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

		/// <summary>
        /// Get Resource Url for RemoveCoupons
        /// </summary>
        /// <param name="orderId">Unique identifier of the order with the coupons to remove.</param>
        /// <param name="updateMode">Specifies whether to remove coupons by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft from which to remove coupons.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string RemoveCouponsUrl(string orderId, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/coupons?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

		
	}
}

