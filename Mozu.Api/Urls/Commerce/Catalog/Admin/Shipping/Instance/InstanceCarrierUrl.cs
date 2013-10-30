
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Shipping.Instance
{
	public partial class InstanceCarrierUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetConfigurations
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetConfigurationsUrl(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/catalog/admin/shipping/instance/carriers/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sortBy", sortBy);
			FormatUrl( ref url, "startIndex", startIndex);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetConfiguration
        /// </summary>
        /// <param name="carrierId">Identifier of the shipping carrier associated with the configuration details to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetConfigurationUrl(string carrierId)
		{
			var url = "/api/commerce/catalog/admin/shipping/instance/carriers/{carrierId}";
			FormatUrl( ref url, "carrierId", carrierId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for CreateConfiguration
        /// </summary>
        /// <param name="carrierId">Identifier of the carrier configuration being created.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string CreateConfigurationUrl(string carrierId)
		{
			var url = "/api/commerce/catalog/admin/shipping/instance/carriers/{carrierId}";
			FormatUrl( ref url, "carrierId", carrierId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for UpdateConfiguration
        /// </summary>
        /// <param name="carrierId">Identifier of the shipping carrier configuration to update.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateConfigurationUrl(string carrierId)
		{
			var url = "/api/commerce/catalog/admin/shipping/instance/carriers/{carrierId}";
			FormatUrl( ref url, "carrierId", carrierId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for DeleteConfiguration
        /// </summary>
        /// <param name="carrierId">Identifier of the specific shipping carrier to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string DeleteConfigurationUrl(string carrierId)
		{
			var url = "/api/commerce/catalog/admin/shipping/instance/carriers/{carrierId}";
			FormatUrl( ref url, "carrierId", carrierId);
			return url;
		}

		
	}
}

