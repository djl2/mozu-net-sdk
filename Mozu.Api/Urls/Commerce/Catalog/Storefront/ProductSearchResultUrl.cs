
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

namespace Mozu.Api.Urls.Commerce.Catalog.Storefront
{
	public partial class ProductSearchResultUrl 
	{

		/// <summary>
        /// Get Resource Url for Search
        /// </summary>
        /// <param name="facet">Individually list the facet fields you want to display in a storefront product search.</param>
        /// <param name="facetFieldRangeQuery">Display a range facet not specified in a template in a storefront product search by listing the facet field and the range to display.</param>
        /// <param name="facetHierDepth">If filtering using category facets in a hierarchy, the number of category hierarchy levels to return for the facet. This option is only available for category facets.</param>
        /// <param name="facetHierPrefix">If filtering using category facets in a hierarchy, the parent categories you want to skip in the storefront product search. This parameter is only available for category facets.</param>
        /// <param name="facetHierValue">If filtering using category facets in a hierarchy, the category in the hierarchy to begin faceting on. This parameter is only available for category facets.</param>
        /// <param name="facetPageSize">The number of facet values to return for one or more facets.</param>
        /// <param name="facetSettings">Settings reserved for future facet search functionality on a storefront product search.</param>
        /// <param name="facetStartIndex">When paging through multiple facets, the startIndex value for each facet.</param>
        /// <param name="facetTemplate">The facet template to use on the storefront. A template displays all facets associated with the template on the storefront product search. Currently, only category-level facet templates are available.</param>
        /// <param name="facetTemplateSubset">Display a subset of the facets defined in the template specified in facetTemplate parameter.</param>
        /// <param name="facetValueFilter">The facet values to apply to the filter.</param>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product search results by any of its properties, including product code, type, category, and name. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=categoryId+eq+12"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="query">The terms to search on.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SearchUrl(string facet, string facetFieldRangeQuery, string facetHierDepth, string facetHierPrefix, string facetHierValue, string facetPageSize, string facetSettings, string facetStartIndex, string facetTemplate, string facetTemplateSubset, string facetValueFilter, string filter, int? pageSize, string query, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/catalog/storefront/productsearch/search/?query={query}&filter={filter}&facetTemplate={facetTemplate}&facetTemplateSubset={facetTemplateSubset}&facet={facet}&facetFieldRangeQuery={facetFieldRangeQuery}&facetHierPrefix={facetHierPrefix}&facetHierValue={facetHierValue}&facetHierDepth={facetHierDepth}&facetStartIndex={facetStartIndex}&facetPageSize={facetPageSize}&facetSettings={facetSettings}&facetValueFilter={facetValueFilter}&sortBy={sortBy}&pageSize={pageSize}&startIndex={startIndex}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "facet", facet);
			mozuUrl.FormatUrl( "facetFieldRangeQuery", facetFieldRangeQuery);
			mozuUrl.FormatUrl( "facetHierDepth", facetHierDepth);
			mozuUrl.FormatUrl( "facetHierPrefix", facetHierPrefix);
			mozuUrl.FormatUrl( "facetHierValue", facetHierValue);
			mozuUrl.FormatUrl( "facetPageSize", facetPageSize);
			mozuUrl.FormatUrl( "facetSettings", facetSettings);
			mozuUrl.FormatUrl( "facetStartIndex", facetStartIndex);
			mozuUrl.FormatUrl( "facetTemplate", facetTemplate);
			mozuUrl.FormatUrl( "facetTemplateSubset", facetTemplateSubset);
			mozuUrl.FormatUrl( "facetValueFilter", facetValueFilter);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "query", query);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for Suggest
        /// </summary>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="q">Text that the shopper is currently entering.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SuggestUrl(int? pageSize, string q)
		{
			var url = "/api/commerce/catalog/storefront/productsearch/suggest?q={q}&pageSize={pageSize}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "q", q);
			return mozuUrl;
		}

								
	}
}

