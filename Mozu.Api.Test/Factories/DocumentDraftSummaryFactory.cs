//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using Newtonsoft.Json;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use the document publishing subresource to manage and publish document drafts in the Content service.
	/// </summary>
	public partial class DocumentDraftSummaryFactory : BaseDataFactory
	{

	/// <summary> 
		/// Retrieves a list of the documents currently in draft state according to any sort criteria defined.
		/// DocumentDraftSummaryFactory.ListDocumentDraftSummaries(handler : handler,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection ListDocumentDraftSummaries(ServiceClientMessageHandler handler, 
 		 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			return ListDocumentDraftSummaries(handler : handler,  documentLists :  null,  pageSize :  null,  startIndex :  null, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// Retrieves a list of the documents currently in draft state according to any sort criteria defined.
		/// DocumentDraftSummaryFactory.ListDocumentDraftSummaries(handler : handler,  documentLists :  documentLists,  pageSize :  pageSize,  startIndex :  startIndex,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<DocumentDraftSummaryPagedCollection>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static Mozu.Api.Contracts.Content.DocumentDraftSummaryPagedCollection ListDocumentDraftSummaries(ServiceClientMessageHandler handler, 
 		 string documentLists, int? pageSize, int? startIndex, 
		 int expectedCode = (int)HttpStatusCode.OK, int successCode = (int)HttpStatusCode.OK)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Content.DocumentDraftSummaryClient.ListDocumentDraftSummariesClient(
				 documentLists :  documentLists,  pageSize :  pageSize,  startIndex :  startIndex		);
			apiClient.WithContext(handler.ApiContext).Execute();
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

				/// <summary> 
		/// Publish one or more document drafts to live content on the site.
		/// DocumentDraftSummaryFactory.PublishDocuments(handler : handler,  documentIds :  documentIds,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static void PublishDocuments(ServiceClientMessageHandler handler, 
 		List<string> documentIds, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
PublishDocuments(handler : handler,  documentLists :  null,  documentIds :  documentIds, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// Publish one or more document drafts to live content on the site.
		/// DocumentDraftSummaryFactory.PublishDocuments(handler : handler,  documentLists :  documentLists,  documentIds :  documentIds,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void PublishDocuments(ServiceClientMessageHandler handler, 
 		string documentLists, List<string> documentIds, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Content.DocumentDraftSummaryClient.PublishDocumentsClient(
				 documentLists :  documentLists,  documentIds :  documentIds		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

			/// <summary> 
		/// Deletes the drafts of the specified documents. Published documents cannot be deleted.
		/// DocumentDraftSummaryFactory.DeleteDocumentDrafts(handler : handler,  documentIds :  documentIds,  expectedCode: expectedCode, successCode: successCode);
		/// </summary>
		public static void DeleteDocumentDrafts(ServiceClientMessageHandler handler, 
 		string documentIds, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
DeleteDocumentDrafts(handler : handler,  documentIds :  documentIds,  documentLists :  null, 
				expectedCode: expectedCode, successCode: successCode);
		}

		/// <summary> 
		/// Deletes the drafts of the specified documents. Published documents cannot be deleted.
		/// DocumentDraftSummaryFactory.DeleteDocumentDrafts(handler : handler,  documentIds :  documentIds,  documentLists :  documentLists,  expectedCode: expectedCode, successCode: successCode); 
		/// var casted = JsonConvert.DeserializeObject<void>(JsonConvert.SerializeObject(result)); 
		/// return casted;
		/// </summary>
		public static void DeleteDocumentDrafts(ServiceClientMessageHandler handler, 
 		string documentIds, string documentLists, 
		 int expectedCode = (int)HttpStatusCode.NoContent, int successCode = (int)HttpStatusCode.NoContent)
		{
			SetSdKparameters();
			var apiClient = Mozu.Api.Clients.Content.DocumentDraftSummaryClient.DeleteDocumentDraftsClient(
				 documentIds :  documentIds,  documentLists :  documentLists		);
			apiClient.WithContext(handler.ApiContext).Execute();
			var noResponse = ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}

		
	}

}


