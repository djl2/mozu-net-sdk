
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
	public partial class ChannelGroupUrl 
	{

		/// <summary>
        /// Get Resource Url for GetChannelGroups
        /// </summary>
        /// <param name="filter">FilterSetAll</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetChannelGroupsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/channelgroups/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetChannelGroup
        /// </summary>
        /// <param name="code">The code that uniquely identifies the channel group.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetChannelGroupUrl(string code)
		{
			var url = "/api/commerce/channelgroups/{code}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateChannelGroup
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateChannelGroupUrl()
		{
			var url = "/api/commerce/channelgroups/";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateChannelGroup
        /// </summary>
        /// <param name="code">Code that identifies the channel group.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateChannelGroupUrl(string code)
		{
			var url = "/api/commerce/channelgroups/{code}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteChannelGroup
        /// </summary>
        /// <param name="code">User-defined code that uniqely identifies the channel group.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteChannelGroupUrl(string code)
		{
			var url = "/api/commerce/channelgroups/{code}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			return mozuUrl;
		}

		
	}
}

