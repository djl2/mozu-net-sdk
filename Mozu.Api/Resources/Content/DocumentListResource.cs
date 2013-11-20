
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
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
	/// Use the document lists resource to organize your site's documents into a hierarchy. Document lists can contain documents, folders, and complete hierarchies of folders, which contain documents with unique names.
	/// </summary>
	public partial class DocumentListResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public DocumentListResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a collection of document lists.
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   var documentListCollection = documentlist.GetDocumentLists();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentListCollection GetDocumentLists()
		{
			return GetDocumentLists( null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a collection of document lists.
		/// </summary>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="sort"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentListCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   var documentListCollection = documentlist.GetDocumentLists( pageSize,  sort,  startIndex, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentListCollection GetDocumentLists(int? pageSize =  null, string sort =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentListCollection> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.GetDocumentListsClient( pageSize,  sort,  startIndex, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieve the details of a document list by providing the list name.
		/// </summary>
		/// <param name="documentListName">The name of the document list.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentList"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documentlist = new DocumentList();
		///   var documentList = documentlist.GetDocumentList( documentListName, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentList GetDocumentList(string documentListName, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentList> response;
			var client = Mozu.Api.Clients.Content.DocumentListClient.GetDocumentListClient( documentListName, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

								
	}

}


