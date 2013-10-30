
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
	public partial class FolderUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the folder to retrieve.</param>
        /// <param name="folderId">The unique identifier of the folder to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "folderId", folderId);
			return url;
		}

		/// <summary>
        /// Get Resource Url for GetFolders
        /// </summary>
        /// <param name="documentListName">The name of the document list that contains this folder.</param>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sort">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">Indicates the zero-based offset in the complete result set where the returned entities begin, when creating paged results from a query. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetFoldersUrl(string documentListName, string filter, long? pageSize, string sort, long? startIndex)
		{
			var url = "/api/content/documentlists/{documentListName}/folders?filter={filter}&pageSize={pageSize}&startIndex={startIndex}&sortBy={sort}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sort", sort);
			FormatUrl( ref url, "startIndex", startIndex);
			return url;
		}

				/// <summary>
        /// Get Resource Url for CreateFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list for which to create a new folder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string CreateFolderUrl(string documentListName)
		{
			var url = "/api/content/documentlists/{documentListName}/folders";
			FormatUrl( ref url, "documentListName", documentListName);
			return url;
		}

				/// <summary>
        /// Get Resource Url for UpdateFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list that contains this folder.</param>
        /// <param name="folderId">Unique identifier of the folder.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "folderId", folderId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for DeleteFolder
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the folder to delete.</param>
        /// <param name="folderId">The unique identifier of the folder to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string DeleteFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "folderId", folderId);
			return url;
		}

		
	}
}
