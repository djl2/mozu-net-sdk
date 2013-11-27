
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Content
{
	public partial class DocumentListUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for GetDocumentLists
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="sort"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentListsUrl(int? pageSize, string sort, int? startIndex)
		{
			var url = "/api/content/documentlists/?pageSize={pageSize}&startIndex={startIndex}&sortBy={sort}";
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sort", sort);
			FormatUrl( ref url, "startIndex", startIndex);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetDocumentList
        /// </summary>
        /// <param name="documentListName"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetDocumentListUrl(string documentListName)
		{
			var url = "/api/content/documentlists/{documentListName}";
			FormatUrl( ref url, "documentListName", documentListName);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

								
	}
}

