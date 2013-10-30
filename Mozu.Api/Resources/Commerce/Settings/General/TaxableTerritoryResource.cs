
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

namespace Mozu.Api.Resources.Commerce.Settings.General
{
	/// <summary>
	/// Use the taxable territories subresource to manage the regional territories for this site that are subejct to sales tax.
	/// </summary>
	public partial class TaxableTerritoryResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public TaxableTerritoryResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of the taxable territories configured for the site.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = taxableterritory.GetTaxableTerritories();
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> GetTaxableTerritories()
		{
						MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.GetTaxableTerritoriesClient();
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Creates a new territory for which to calculate sales tax.
		/// </summary>
		/// <param name="taxableTerritory">Properties of the taxable territory to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = taxableterritory.AddTaxableTerritory( taxableTerritory);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory AddTaxableTerritory(Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory taxableTerritory)
		{
						MozuClient<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.AddTaxableTerritoryClient( taxableTerritory);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Updates one or more taxable territories configured for a site.
		/// </summary>
		/// <param name="taxableterritories">Properties of the taxable territories to update.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = taxableterritory.UpdateTaxableTerritories( taxableterritories);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> UpdateTaxableTerritories(List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> taxableterritories)
		{
						MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.UpdateTaxableTerritoriesClient( taxableterritories);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				
	}

}


