
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

namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// Use the site data resource to store site-level information required for a third-party application in the Mozu database.
	/// </summary>
	public partial class SiteDataResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public SiteDataResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the value of a record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry query string used to retrieve the record information.</param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var sitedata = new SiteData();
		///   var string = sitedata.GetDBValue( dbEntryQuery);
		/// </code>
		/// </example>
		public virtual string GetDBValue(string dbEntryQuery)
		{
						MozuClient<string> response;
			var client = Mozu.Api.Clients.Platform.SiteDataClient.GetDBValueClient( dbEntryQuery);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Creates a new record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var sitedata = new SiteData();
		///   sitedata.CreateDBValue( dbEntryQuery,  value);
		/// </code>
		/// </example>
		public virtual void CreateDBValue(string dbEntryQuery, string value)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Platform.SiteDataClient.CreateDBValueClient( dbEntryQuery,  value);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

				/// <summary>
		/// Updates a record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry query string used to update the record information.</param>
		/// <param name="value">The database value to update.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var sitedata = new SiteData();
		///   sitedata.UpdateDBValue( dbEntryQuery,  value);
		/// </code>
		/// </example>
		public virtual void UpdateDBValue(string dbEntryQuery, string value)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Platform.SiteDataClient.UpdateDBValueClient( dbEntryQuery,  value);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

				/// <summary>
		/// Removes a previously defined record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var sitedata = new SiteData();
		///   sitedata.DeleteDBValue( dbEntryQuery);
		/// </code>
		/// </example>
		public virtual void DeleteDBValue(string dbEntryQuery)
		{
						MozuClient response;
			var client = Mozu.Api.Clients.Platform.SiteDataClient.DeleteDBValueClient( dbEntryQuery);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();

		}

		
	}

}


