
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
	/// 
	/// </summary>
	public partial class MasterCatalogResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public MasterCatalogResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.MasterCatalogCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var mastercatalog = new MasterCatalog();
		///   var masterCatalogCollection = mastercatalog.GetMasterCatalogs(authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.MasterCatalogCollection GetMasterCatalogs(AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalogCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.MasterCatalogClient.GetMasterCatalogsClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="masterCatalogId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.MasterCatalog"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var mastercatalog = new MasterCatalog();
		///   var masterCatalog = mastercatalog.GetMasterCatalog(dataViewMode,  masterCatalogId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.MasterCatalog GetMasterCatalog(DataViewMode dataViewMode, int masterCatalogId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalog> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.MasterCatalogClient.GetMasterCatalogClient(dataViewMode,  masterCatalogId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

						/// <summary>
		/// 
		/// </summary>
		/// <param name="masterCatalogId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="masterCatalog"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.MasterCatalog"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var mastercatalog = new MasterCatalog();
		///   var masterCatalog = mastercatalog.UpdateMasterCatalog(dataViewMode,  masterCatalog,  masterCatalogId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.MasterCatalog UpdateMasterCatalog(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.MasterCatalog masterCatalog, int masterCatalogId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.MasterCatalog> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.MasterCatalogClient.UpdateMasterCatalogClient(dataViewMode,  masterCatalog,  masterCatalogId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				
	}

}


