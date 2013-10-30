
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// 
	/// </summary>
	public partial class SiteGroupResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public SiteGroupResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SiteGroupCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var sitegroup = new SiteGroup();
		///   var siteGroupCollection = sitegroup.GetSiteGroups();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.SiteGroupCollection GetSiteGroups()
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.SiteGroupCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SiteGroupClient.GetSiteGroupsClient();
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="siteGroupId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SiteGroup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var sitegroup = new SiteGroup();
		///   var siteGroup = sitegroup.GetSiteGroup( siteGroupId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.SiteGroup GetSiteGroup(int siteGroupId)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.SiteGroup> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SiteGroupClient.GetSiteGroupClient( siteGroupId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

						/// <summary>
		/// 
		/// </summary>
		/// <param name="siteGroupId"></param>
		/// <param name="siteGroup"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SiteGroup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var sitegroup = new SiteGroup();
		///   var siteGroup = sitegroup.UpdateSiteGroup( siteGroupId,  siteGroup);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.SiteGroup UpdateSiteGroup(int siteGroupId, Mozu.Api.Contracts.ProductAdmin.SiteGroup siteGroup)
		{
						MozuClient<Mozu.Api.Contracts.ProductAdmin.SiteGroup> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SiteGroupClient.UpdateSiteGroupClient( siteGroupId,  siteGroup);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				
	}

}


