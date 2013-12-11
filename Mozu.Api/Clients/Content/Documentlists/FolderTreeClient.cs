
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
	/// Use the folder tree subresource to view individual folders in the document hierarchy.
	/// </summary>
	public partial class FolderTreeClient 	{
		
		/// <summary>
		/// Retrieves the folder hierarchy used to organize documents in lists.
		/// </summary>
		/// <param name="documentListName">The name of the document list that contains this folder hierarchy.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.FolderTree"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFolderTree(dataViewMode,  documentListName);
		///   var folderTreeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.FolderTree> GetFolderTreeClient(DataViewMode dataViewMode, string documentListName)
		{
			return GetFolderTreeClient(dataViewMode,  documentListName,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves the folder hierarchy used to organize documents in lists.
		/// </summary>
		/// <param name="documentListName">The name of the document list that contains this folder hierarchy.</param>
		/// <param name="levels">The number of levels in the folder hierarchy to return.</param>
		/// <param name="rootFolderId">The unique identifier of the top-level folder in the document list.</param>
		/// <param name="rootFolderPath">The location in the document hierarchy of the top-level folder in the document list.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.FolderTree"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetFolderTree(dataViewMode,  documentListName,  levels,  rootFolderId,  rootFolderPath, authTicket);
		///   var folderTreeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.FolderTree> GetFolderTreeClient(DataViewMode dataViewMode, string documentListName, int? levels =  null, string rootFolderId =  null, string rootFolderPath =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.Documentlists.FolderTreeUrl.GetFolderTreeUrl(documentListName, levels, rootFolderId, rootFolderPath);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.FolderTree>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}


	}

}


