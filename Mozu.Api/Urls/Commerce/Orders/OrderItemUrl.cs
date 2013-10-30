
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
	public partial class OrderItemUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetOrderItem
        /// </summary>
        /// <param name="draft">If true, retrieve the draft version of this order item, which might include uncommitted changes to the order item, the order, or other order components.</param>
        /// <param name="orderId">Unique identifier of the order item to retrieve.</param>
        /// <param name="orderItemId">Unique identifier of the order item details to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetOrderItemUrl(bool? draft, string orderId, string orderItemId)
		{
			var url = "/api/commerce/orders/{orderId}/items/{orderItemId}?draft={draft}";
			FormatUrl( ref url, "draft", draft);
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "orderItemId", orderItemId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetOrderItems
        /// </summary>
        /// <param name="draft">If true, retrieve the draft version of the order's items, which might include uncommitted changes to one or more order items, the order itself, or other order components.</param>
        /// <param name="orderId">Unique identifier of the order items to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetOrderItemsUrl(bool? draft, string orderId)
		{
			var url = "/api/commerce/orders/{orderId}/items?draft={draft}";
			FormatUrl( ref url, "draft", draft);
			FormatUrl( ref url, "orderId", orderId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for CreateOrderItem
        /// </summary>
        /// <param name="orderId">Unique identifier of the order for which to add the item.</param>
        /// <param name="updateMode">Specifies whether to add the item by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft for which to add the item.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string CreateOrderItemUrl(string orderId, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/items?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

				/// <summary>
        /// Get Resource Url for UpdateOrderItemDiscount
        /// </summary>
        /// <param name="discountId">Unique identifier of the discount. System-supplied and read only.</param>
        /// <param name="orderId">Unique identifier of the order associated with the item discount.</param>
        /// <param name="orderItemId">Unique identifier of the item in the order.</param>
        /// <param name="updateMode">Specifies whether to change the item discount by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft for which to update the item discount.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateOrderItemDiscountUrl(int discountId, string orderId, string orderItemId, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/items/{orderItemId}/discounts/{discountId}?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "discountId", discountId);
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "orderItemId", orderItemId);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

		/// <summary>
        /// Get Resource Url for UpdateItemProductPrice
        /// </summary>
        /// <param name="orderId">Unique identifier of the order containing the item to price override.</param>
        /// <param name="orderItemId">Unique identifier of the item in the order to price override.</param>
        /// <param name="price">The override price to specify for this item in the specified order.</param>
        /// <param name="updateMode">Specifies whether to change the product price by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft for which to update the item price.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateItemProductPriceUrl(string orderId, string orderItemId, decimal price, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/items/{orderItemId}/price/{price}?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "orderItemId", orderItemId);
			FormatUrl( ref url, "price", price);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

		/// <summary>
        /// Get Resource Url for UpdateItemQuantity
        /// </summary>
        /// <param name="orderId">Unique identifier of the order containing the item to update quantity.</param>
        /// <param name="orderItemId">Unique identifier of the item in the order to update quantity.</param>
        /// <param name="quantity">The quantity of the item in the order to update.</param>
        /// <param name="updateMode">Specifies whether to change the item quantity by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft for which to update the item quantity.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateItemQuantityUrl(string orderId, string orderItemId, int quantity, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/items/{orderItemId}/quantity/{quantity}?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "orderItemId", orderItemId);
			FormatUrl( ref url, "quantity", quantity);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

				/// <summary>
        /// Get Resource Url for DeleteOrderItem
        /// </summary>
        /// <param name="orderId">Unique identifier of the order with the item to remove.</param>
        /// <param name="orderItemId">Unique identifier of the item to remove from the order.</param>
        /// <param name="updateMode">Specifies whether to remove the item by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
        /// <param name="version">If applicable, the version of the order or order draft from which to delete the item.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string DeleteOrderItemUrl(string orderId, string orderItemId, string updateMode, string version)
		{
			var url = "/api/commerce/orders/{orderId}/items/{orderItemId}?updatemode={updateMode}&version={version}";
			FormatUrl( ref url, "orderId", orderId);
			FormatUrl( ref url, "orderItemId", orderItemId);
			FormatUrl( ref url, "updateMode", updateMode);
			FormatUrl( ref url, "version", version);
			return url;
		}

		
	}
}
