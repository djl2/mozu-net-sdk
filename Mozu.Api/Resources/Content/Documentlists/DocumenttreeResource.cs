
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


namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Use the document tree subresource to retrieve documents and manage content within the document hierarchy.
	/// </summary>
	public partial class DocumentTreeResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public DocumentTreeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieve the content associated with the document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.GetTreeDocumentContent( documentListName,  documentName);
		/// </code>
		/// </example>
		public virtual void GetTreeDocumentContent(string documentListName, string documentName)
		{
			GetTreeDocumentContent( documentListName,  documentName,  null,  null, null);
		}

		/// <summary>
		/// Retrieve the content associated with the document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
		/// <param name="folderPath">If applicable, the path of the folder hierarchy location associated with the document.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.GetTreeDocumentContent( documentListName,  documentName,  folderId,  folderPath, authTicket);
		/// </code>
		/// </example>
		public virtual void GetTreeDocumentContent(string documentListName, string documentName, string folderId =  null, string folderPath =  null, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentContentClient( documentListName,  documentName,  folderId,  folderPath, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// Retrieves a document based on its document list and folder path in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var document = documenttree.GetTreeDocument( documentListName,  documentName);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.Document GetTreeDocument(string documentListName, string documentName)
		{
			return GetTreeDocument( documentListName,  documentName,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a document based on its document list and folder path in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
		/// <param name="folderPath">If applicable, the path of the folder hierarchy location that contains the document.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   var document = documenttree.GetTreeDocument( documentListName,  documentName,  folderId,  folderPath, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.Document GetTreeDocument(string documentListName, string documentName, string folderId =  null, string folderPath =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.GetTreeDocumentClient( documentListName,  documentName,  folderId,  folderPath, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

						/// <summary>
		/// Updates the content associated with a document, such as a product image or PDF specifications file, based on the document's position in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="stream"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.UpdateTreeDocumentContent( stream,  documentListName,  documentName);
		/// </code>
		/// </example>
		public virtual void UpdateTreeDocumentContent(System.IO.Stream stream, string documentListName, string documentName)
		{
			UpdateTreeDocumentContent( stream,  documentListName,  documentName,  null,  null, null);
		}

		/// <summary>
		/// Updates the content associated with a document, such as a product image or PDF specifications file, based on the document's position in the document hierarchy.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
		/// <param name="folderPath">If applicable, the path of the folder hierarchy location associated with the document.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="stream"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.UpdateTreeDocumentContent( stream,  documentListName,  documentName,  folderId,  folderPath, authTicket);
		/// </code>
		/// </example>
		public virtual void UpdateTreeDocumentContent(System.IO.Stream stream, string documentListName, string documentName, string folderId =  null, string folderPath =  null, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.UpdateTreeDocumentContentClient( stream,  documentListName,  documentName,  folderId,  folderPath, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

				/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="stream"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.DeleteTreeDocumentContent( stream,  documentListName,  documentName);
		/// </code>
		/// </example>
		public virtual void DeleteTreeDocumentContent(System.IO.Stream stream, string documentListName, string documentName)
		{
			DeleteTreeDocumentContent( stream,  documentListName,  documentName,  null,  null, null);
		}

		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specifications file.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the document.</param>
		/// <param name="documentName">The name of the document, which is unique within its folder.</param>
		/// <param name="folderId">If applicable, the unique identifier of the folder that contains the document.</param>
		/// <param name="folderPath">If applicable, the path of the folder hierarchy location associated with the document.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="stream"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttree = new DocumentTree();
		///   documenttree.DeleteTreeDocumentContent( stream,  documentListName,  documentName,  folderId,  folderPath, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteTreeDocumentContent(System.IO.Stream stream, string documentListName, string documentName, string folderId =  null, string folderPath =  null, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentTreeClient.DeleteTreeDocumentContentClient( stream,  documentListName,  documentName,  folderId,  folderPath, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


