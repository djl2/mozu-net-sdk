
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
	/// 
	/// </summary>
	public partial class FacetResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public FacetResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentListName"></param>
		/// <param name="propertyName"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Content.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var facet = facet.GetFacets( documentListName,  propertyName, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Content.Facet> GetFacets(string documentListName, string propertyName, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.Content.Facet>> response;
			var client = Mozu.Api.Clients.Content.Documentlists.FacetClient.GetFacetsClient( documentListName,  propertyName, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

								
	}

}


