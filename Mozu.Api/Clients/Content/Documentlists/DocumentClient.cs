
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Content.Documentlists
{
	/// <summary>
	/// Use this subresource to manage documents in a document list.
	/// </summary>
	public partial class DocumentClient 	{
		
		/// <summary>
		/// Retrieves a specific document within the specified document list by providing the document ID.
		/// </summary>
		/// <param name="documentId">Identifier of the document being retrieved.</param>
		/// <param name="documentListName">The name of the document list associated with the document to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Document"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocument(dataViewMode,  documentListName,  documentId);
		///   var documentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Document> GetDocumentClient(DataViewMode dataViewMode, string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.GetDocumentUrl(documentId, documentListName);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Document>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieve the content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document.</param>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="System.IO.Stream"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocumentContent(dataViewMode,  documentListName,  documentId);
		///   var streamClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<System.IO.Stream> GetDocumentContentClient(DataViewMode dataViewMode, string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.GetDocumentContentUrl(documentId, documentListName);
			const string verb = "GET";
			var mozuClient = new MozuClient<System.IO.Stream>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a collection of documents according to any filter and sort criteria.
		/// </summary>
		/// <param name="documentListName">The name of the document list.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocuments(dataViewMode,  documentListName);
		///   var documentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> GetDocumentsClient(DataViewMode dataViewMode, string documentListName)
		{
			return GetDocumentsClient(dataViewMode,  documentListName,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a collection of documents according to any filter and sort criteria.
		/// </summary>
		/// <param name="documentListName">The name of the document list.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter a document's search results by any of its properties, including its name or folder path. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=Name+sw+Events"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDocuments(dataViewMode,  documentListName,  filter,  sortBy,  pageSize,  startIndex);
		///   var documentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> GetDocumentsClient(DataViewMode dataViewMode, string documentListName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.GetDocumentsUrl(documentListName, filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.DocumentCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new document in an existing list.
		/// </summary>
		/// <param name="documentListName">The descriptive alphanumeric document list name being created.</param>
		/// <param name="document">The descriptive name of the newly created document.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Document"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDocument(dataViewMode,  document,  documentListName);
		///   var documentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Document> CreateDocumentClient(DataViewMode dataViewMode, Mozu.Api.Contracts.Content.Document document, string documentListName)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.CreateDocumentUrl(documentListName);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Document>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.Document>(document)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates a document in a document list.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document to update.</param>
		/// <param name="documentListName">Name of the document list associated with the document.</param>
		/// <param name="document">Properties of the document to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Document"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDocument(dataViewMode,  document,  documentListName,  documentId);
		///   var documentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Document> UpdateDocumentClient(DataViewMode dataViewMode, Mozu.Api.Contracts.Content.Document document, string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.UpdateDocumentUrl(documentId, documentListName);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Document>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Content.Document>(document)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Updates the content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document.</param>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="stream"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDocumentContent(dataViewMode,  stream,  documentListName,  documentId,  contentType);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient UpdateDocumentContentClient(DataViewMode dataViewMode, System.IO.Stream stream, string documentListName, string documentId, String  contentType= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.UpdateDocumentContentUrl(documentId, documentListName);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(stream)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
									.WithHeader(Headers.CONTENT_TYPE ,contentType)
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes a specific document based on the specified document ID.
		/// </summary>
		/// <param name="documentId">Identifier of the document being deleted.</param>
		/// <param name="documentListName">The name of the document list associated with the document list being deleted.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDocument(dataViewMode,  documentListName,  documentId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDocumentClient(DataViewMode dataViewMode, string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.DeleteDocumentUrl(documentId, documentListName);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specification, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier of the document.</param>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDocumentContent(dataViewMode,  documentListName,  documentId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDocumentContentClient(DataViewMode dataViewMode, string documentListName, string documentId)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.DocumentUrl.DeleteDocumentContentUrl(documentId, documentListName);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


