
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
	public partial class FolderUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for GetFolder
        /// </summary>
        /// <param name="documentListName"></param>
        /// <param name="folderId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "folderId", folderId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		/// <summary>
        /// Get Resource Url for GetFolders
        /// </summary>
        /// <param name="documentListName"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="sort"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetFoldersUrl(string documentListName, string filter, int? pageSize, string sort, int? startIndex)
		{
			var url = "/api/content/documentlists/{documentListName}/folders?filter={filter}&pageSize={pageSize}&startIndex={startIndex}&sortBy={sort}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "filter", filter);
			FormatUrl( ref url, "pageSize", pageSize);
			FormatUrl( ref url, "sort", sort);
			FormatUrl( ref url, "startIndex", startIndex);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for CreateFolder
        /// </summary>
        /// <param name="documentListName"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateFolderUrl(string documentListName)
		{
			var url = "/api/content/documentlists/{documentListName}/folders";
			FormatUrl( ref url, "documentListName", documentListName);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for UpdateFolder
        /// </summary>
        /// <param name="documentListName"></param>
        /// <param name="folderId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "folderId", folderId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for DeleteFolder
        /// </summary>
        /// <param name="documentListName"></param>
        /// <param name="folderId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteFolderUrl(string documentListName, string folderId)
		{
			var url = "/api/content/documentlists/{documentListName}/folders/{folderId}";
			FormatUrl( ref url, "documentListName", documentListName);
			FormatUrl( ref url, "folderId", folderId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		
	}
}

