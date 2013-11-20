
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


namespace Mozu.Api.Clients.Content.Documentlists
{
	/// <summary>
	/// Use the folders subresource to organize content into folders.
	/// </summary>
	public partial class FolderClient 	{
		
		/// <summary>
		/// Retrieves the properties of an existing folder.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the folder to retrieve.</param>
		/// <param name="folderId">The unique identifier of the folder to retrieve.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Folder"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFolder( documentListName,  folderId, authTicket);
		///   var folderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Folder> GetFolderClient(string documentListName, string folderId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.FolderUrl.GetFolderUrl(documentListName, folderId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Folder>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieve a list of content folders according to any filter and sort criteria.
		/// </summary>
		/// <param name="documentListName">The name of the document list that contains this folder.</param>
		/// <param name="filter">"A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - ""filter=IsDisplayed+eq+true"""</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.FolderCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFolders( documentListName,  filter);
		///   var folderCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.FolderCollection> GetFoldersClient(string documentListName, string filter)
		{
			return GetFoldersClient( documentListName,  filter,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieve a list of content folders according to any filter and sort criteria.
		/// </summary>
		/// <param name="documentListName">The name of the document list that contains this folder.</param>
		/// <param name="filter">"A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - ""filter=IsDisplayed+eq+true"""</param>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="sort">"The property by which to sort results and whether the results appear in ascending (a-z) order, represented by 'ASC' or in descending (z-a) order, represented by 'DESC'. The sortBy parameter follows an available property. <b>For example: sortBy=productCode+asc</b>"</param>
		/// <param name="startIndex">"Used to create paged results from a query. Indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3."</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.FolderCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFolders( documentListName,  filter,  pageSize,  sort,  startIndex, authTicket);
		///   var folderCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.FolderCollection> GetFoldersClient(string documentListName, string filter, int? pageSize =  null, string sort =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.FolderUrl.GetFoldersUrl(documentListName, filter, pageSize, sort, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.FolderCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Creates a new folder.
		/// </summary>
		/// <param name="documentListName">The name of the document list for which to create a new folder.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="folder">The name of the newly created folder.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Folder"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateFolder( folder,  documentListName, authTicket);
		///   var folderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Folder> CreateFolderClient(Mozu.Api.Contracts.Content.Folder folder, string documentListName, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.FolderUrl.CreateFolderUrl(documentListName);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Folder>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Content.Folder>(folder);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Updates an existing content folder in a document list.
		/// </summary>
		/// <param name="documentListName">The name of the document list that contains this folder.</param>
		/// <param name="folderId">Unique identifier of the folder.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="folder">Properties of the folder to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.Folder"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateFolder( folder,  documentListName,  folderId, authTicket);
		///   var folderClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.Folder> UpdateFolderClient(Mozu.Api.Contracts.Content.Folder folder, string documentListName, string folderId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.FolderUrl.UpdateFolderUrl(documentListName, folderId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.Folder>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Content.Folder>(folder);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Deletes a folder of documents from the specified document list.
		/// </summary>
		/// <param name="documentListName">The name of the document list associated with the folder to delete.</param>
		/// <param name="folderId">The unique identifier of the folder to delete.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteFolder( documentListName,  folderId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteFolderClient(string documentListName, string folderId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.FolderUrl.DeleteFolderUrl(documentListName, folderId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


