
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Content.Documentlists
{
	public partial class FacetUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetFacets
        /// </summary>
        /// <param name="documentListName">The document list associated with the facets to retrieve.</param>
        /// <param name="propertyName">The property name associated with the facets to retrieve.</param>
        /// <param name="publishState">The current state of the document, which is Active, Draft, or Latest. Active documents are published and cannot be deleted. Querying Latest returns the most recent version of the document, regardless of whether it is published or a draft.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetFacetsUrl(string documentListName, string propertyName, string publishState)
		{
			var url = "/api/content/documentlists/{documentListName}/facets/{propertyName}?publishState={publishState}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "propertyName", propertyName);
			FormatUrl( ref url, "publishState", publishState);
			return url;
		}

								
	}
}

