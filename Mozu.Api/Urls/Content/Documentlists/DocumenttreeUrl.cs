
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
	public partial class DocumentTreeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetTreeDocumentContent
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
        /// <param name="folderPath">If applicable, the path of the folder hierarchy location associated with the document.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTreeDocumentContentUrl(string documentListName, string documentName, string folderId, string folderPath)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}/content?folderPath={folderPath}&folderId={folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			mozuUrl.FormatUrl( "folderId", folderId);
			mozuUrl.FormatUrl( "folderPath", folderPath);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetTreeDocument
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
        /// <param name="folderPath">If applicable, the path of the folder hierarchy location that contains the document.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTreeDocumentUrl(string documentListName, string documentName, string folderId, string folderPath)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}?folderPath={folderPath}&folderId={folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			mozuUrl.FormatUrl( "folderId", folderId);
			mozuUrl.FormatUrl( "folderPath", folderPath);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for UpdateTreeDocumentContent
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
        /// <param name="folderPath">If applicable, the path of the folder hierarchy location associated with the document.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateTreeDocumentContentUrl(string documentListName, string documentName, string folderId, string folderPath)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}/content?folderPath={folderPath}&folderId={folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			mozuUrl.FormatUrl( "folderId", folderId);
			mozuUrl.FormatUrl( "folderPath", folderPath);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteTreeDocumentContent
        /// </summary>
        /// <param name="documentListName">The name of the document list associated with the document.</param>
        /// <param name="documentName">The name of the document, which is unique within its folder.</param>
        /// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
        /// <param name="folderPath">If applicable, the path of the folder hierarchy location associated with the document.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteTreeDocumentContentUrl(string documentListName, string documentName, string folderId, string folderPath)
		{
			var url = "/api/content/documentlists/{documentListName}/documentTree/{documentName}/content?folderPath={folderPath}&folderId={folderId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "documentListName", documentListName);
			mozuUrl.FormatUrl( "documentName", documentName);
			mozuUrl.FormatUrl( "folderId", folderId);
			mozuUrl.FormatUrl( "folderPath", folderPath);
			return mozuUrl;
		}

		
	}
}

