
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
	public partial class PublishingScopeResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public PublishingScopeResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
				/// <summary>
		/// 
		/// </summary>
		/// <param name="publishScope"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.DiscardDrafts( publishScope);
		/// </code>
		/// </example>
		public virtual void DiscardDrafts(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DiscardDraftsClient( publishScope);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="publishScope"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.PublishDrafts( publishScope);
		/// </code>
		/// </example>
		public virtual void PublishDrafts(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.PublishDraftsClient( publishScope);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

						
	}

}


