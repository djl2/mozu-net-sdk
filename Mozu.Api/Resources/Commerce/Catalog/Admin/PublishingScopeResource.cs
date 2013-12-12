
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Product Publishing resource to publish or discard pending changes to product definitions in the master catalog.
	/// </summary>
	public partial class PublishingScopeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public PublishingScopeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Deletes the draft version of product changes for each product code specified in the request.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="publishScope">Properties of the pending product changes to include in this operation.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.DiscardDrafts(dataViewMode,  publishScope, authTicket);
		/// </code>
		/// </example>
		public virtual void DiscardDrafts(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DiscardDraftsClient(dataViewMode,  publishScope, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// Publishes the draft version of product changes for each product code specified in the request, and changes the product publish state to "live".
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="publishScope">Properties of the pending product changes to include in this operation.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.PublishDrafts(dataViewMode,  publishScope, authTicket);
		/// </code>
		/// </example>
		public virtual void PublishDrafts(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.PublishDraftsClient(dataViewMode,  publishScope, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


