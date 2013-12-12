
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
	public partial class FolderUrl 
	{

		/// <summary>
        /// Get Resource Url for GetFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the folder to retrieve.</param>
        /// <param name="folderId">The unique identifier of the folder to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "folderId", folderId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetFolders
        /// </summary>
        /// <param name="documentListName">The name of the document list that contains this folder.</param>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sort">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetFoldersUrl(string documentListName, string filter, int? pageSize, string sort, int? startIndex)
		{
			var url = "/api/content/documentlists/{documentListName}/folders?filter={filter}&pageSize={pageSize}&startIndex={startIndex}&sortBy={sort}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "sort", sort);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list for which to create a new folder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateFolderUrl(string documentListName)
		{
			var url = "/api/content/documentlists/{documentListName}/folders";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list that contains this folder.</param>
        /// <param name="folderId">Unique identifier of the folder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "folderId", folderId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the folder to delete.</param>
        /// <param name="folderId">The unique identifier of the folder to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "folderId", folderId);
			return mozuUrl;
		}

		
	}
}

