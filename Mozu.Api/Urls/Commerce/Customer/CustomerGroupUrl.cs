
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Customer
{
	public partial class CustomerGroupUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for GetGroups
        /// </summary>
        /// <param name="filter">"A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - ""filter=IsDisplayed+eq+true"""</param>
        /// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
        /// <param name="sortBy">"The property by which to sort results and whether the results appear in ascending (a-z) order, represented by 'ASC' or in descending (z-a) order, represented by 'DESC'. The sortBy parameter follows an available property. <b>For example: sortBy=productCode+asc</b>"</param>
        /// <param name="startIndex">"Used to create paged results from a query. Indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3."</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetGroupsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/customer/groups/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sortBy", sortBy);
			FormatUrl( ref url, "startIndex", startIndex);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetGroup
        /// </summary>
        /// <param name="groupId">Identifier of the customer group to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetGroupUrl(int groupId)
		{
			var url = "/api/commerce/customer/groups/{groupId}";
			FormatUrl( ref url, "groupId", groupId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for AddGroup
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddGroupUrl()
		{
			var url = "/api/commerce/customer/groups/";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for UpdateGroup
        /// </summary>
        /// <param name="groupId">Identifier of the customer group to update.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateGroupUrl(int groupId)
		{
			var url = "/api/commerce/customer/groups/{groupId}";
			FormatUrl( ref url, "groupId", groupId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for DeleteGroup
        /// </summary>
        /// <param name="groupId">Identifier of the customer group to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteGroupUrl(int groupId)
		{
			var url = "/api/commerce/customer/groups/{groupId}";
			FormatUrl( ref url, "groupId", groupId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		
	}
}

