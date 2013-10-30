
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
	public partial class DocumentListUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetDocumentLists
        /// </summary>
        /// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sort"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetDocumentListsUrl(long? pageSize, string sort, long? startIndex)
		{
			var url = "/api/content/documentlists/?pageSize={pageSize}&startIndex={startIndex}&sortBy={sort}";
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sort", sort);
			FormatUrl( ref url, "startIndex", startIndex);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetDocumentList
        /// </summary>
        /// <param name="documentListName">The name of the document list.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetDocumentListUrl(string documentListName)
		{
			var url = "/api/content/documentlists/{documentListName}";
			FormatUrl( ref url, "documentListName", documentListName);
			return url;
		}

								
	}
}

