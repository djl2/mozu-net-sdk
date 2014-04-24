
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

namespace Mozu.Api.Urls.Commerce
{
	public partial class InStockNotificationSubscriptionUrl 
	{

		/// <summary>
        /// Get Resource Url for GetInStockNotificationSubscriptions
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetInStockNotificationSubscriptionsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/instocknotifications/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetInStockNotificationSubscription
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetInStockNotificationSubscriptionUrl(int id)
		{
			var url = "/api/commerce/instocknotifications/{id}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddInStockNotificationSubscription
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddInStockNotificationSubscriptionUrl()
		{
			var url = "/api/commerce/instocknotifications/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for DeleteInStockNotificationSubscription
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteInStockNotificationSubscriptionUrl(int id)
		{
			var url = "/api/commerce/instocknotifications/{id}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "id", id);
			return mozuUrl;
		}

		
	}
}

