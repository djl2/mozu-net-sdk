
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class PublishingScopeUrl : MozuUrl
	{

				/// <summary>
        /// Get Resource Url for DiscardDrafts
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DiscardDraftsUrl()
		{
			var url = "/api/commerce/catalog/admin/publishing/discarddrafts";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for PublishDrafts
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl PublishDraftsUrl()
		{
			var url = "/api/commerce/catalog/admin/publishing/publishdrafts";
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

						
	}
}

