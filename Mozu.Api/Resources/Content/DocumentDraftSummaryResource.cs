
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


namespace Mozu.Api.Resources.Content
{
	/// <summary>
	/// Use the document publishing subresource to manage and publish document drafts in the Content service.
	/// </summary>
	public partial class DocumentDraftSummaryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public DocumentDraftSummaryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of the documents currently in draft state, according to any defined filter and sort criteria.
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentdraftsummary = new DocumentDraftSummary();
		///   var documentDraftSummaryPagedCollection = documentdraftsummary.ListDocumentDraftSummaries(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection ListDocumentDraftSummaries(DataViewMode dataViewMode)
		{
			return ListDocumentDraftSummaries(dataViewMode,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of the documents currently in draft state, according to any defined filter and sort criteria.
		/// </summary>
		/// <param name="documentLists">Lists that contain the document drafts.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentdraftsummary = new DocumentDraftSummary();
		///   var documentDraftSummaryPagedCollection = documentdraftsummary.ListDocumentDraftSummaries(dataViewMode,  pageSize,  startIndex,  documentLists);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection ListDocumentDraftSummaries(DataViewMode dataViewMode, int? pageSize =  null, int? startIndex =  null, string documentLists =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection> response;
			var client = Mozu.Api.Clients.Content.DocumentDraftSummaryClient.ListDocumentDraftSummariesClient(dataViewMode,  pageSize,  startIndex,  documentLists);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes the drafts of the specified documents. Published documents cannot be deleted.
		/// </summary>
		/// <param name="documentIds">Unique identifiers of the documents to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documentdraftsummary = new DocumentDraftSummary();
		///   documentdraftsummary.DeleteDocumentDrafts(dataViewMode,  documentIds);
		/// </code>
		/// </example>
		public virtual void DeleteDocumentDrafts(DataViewMode dataViewMode, List<string> documentIds)
		{
			DeleteDocumentDrafts(dataViewMode,  documentIds,  null);
		}

		/// <summary>
		/// Deletes the drafts of the specified documents. Published documents cannot be deleted.
		/// </summary>
		/// <param name="documentLists">List of document lists that contain documents to delete.</param>
		/// <param name="documentIds">Unique identifiers of the documents to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documentdraftsummary = new DocumentDraftSummary();
		///   documentdraftsummary.DeleteDocumentDrafts(dataViewMode,  documentIds,  documentLists);
		/// </code>
		/// </example>
		public virtual void DeleteDocumentDrafts(DataViewMode dataViewMode, List<string> documentIds, string documentLists =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.DocumentDraftSummaryClient.DeleteDocumentDraftsClient(dataViewMode,  documentIds,  documentLists);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// Publish one or more document drafts to live content on the site.
		/// </summary>
		/// <param name="documentIds">List of unique identifiers of the document drafts to publish.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documentdraftsummary = new DocumentDraftSummary();
		///   documentdraftsummary.PublishDocuments(dataViewMode,  documentIds);
		/// </code>
		/// </example>
		public virtual void PublishDocuments(DataViewMode dataViewMode, List<string> documentIds)
		{
			PublishDocuments(dataViewMode,  documentIds,  null);
		}

		/// <summary>
		/// Publish one or more document drafts to live content on the site.
		/// </summary>
		/// <param name="documentLists">List of document lists that contain documents to publish.</param>
		/// <param name="documentIds">List of unique identifiers of the document drafts to publish.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documentdraftsummary = new DocumentDraftSummary();
		///   documentdraftsummary.PublishDocuments(dataViewMode,  documentIds,  documentLists);
		/// </code>
		/// </example>
		public virtual void PublishDocuments(DataViewMode dataViewMode, List<string> documentIds, string documentLists =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.DocumentDraftSummaryClient.PublishDocumentsClient(dataViewMode,  documentIds,  documentLists);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


