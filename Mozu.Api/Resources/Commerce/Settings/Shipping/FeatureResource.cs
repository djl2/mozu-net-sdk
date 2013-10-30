
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

namespace Mozu.Api.Resources.Commerce.Settings.Shipping
{
	/// <summary>
	/// Use the active rate providers subresource to manage entities that provide estimated shipping rate calculations. Active rate providers represent carrier configurations set up in the shipping admin service.
	/// </summary>
	public partial class FeatureResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public FeatureResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of the active rate providers configured for the site.
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Core.Feature"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var feature = new Feature();
		///   var feature = feature.GetActiveRateProviders();
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Core.Feature> GetActiveRateProviders()
		{
						MozuClient<List<Mozu.Api.Contracts.Core.Feature>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Shipping.FeatureClient.GetActiveRateProvidersClient();
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Creates a new active rate provider for the site.
		/// </summary>
		/// <param name="activeRateProvider">Properties of the active rate provider to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Feature"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var feature = new Feature();
		///   var feature = feature.AddActiveRateProvider( activeRateProvider);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.Feature AddActiveRateProvider(Mozu.Api.Contracts.Core.Feature activeRateProvider)
		{
						MozuClient<Mozu.Api.Contracts.Core.Feature> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Shipping.FeatureClient.AddActiveRateProviderClient( activeRateProvider);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Updates the active rate providers configured for the site.
		/// </summary>
		/// <param name="activeRateProviders">Properties of the active rate provider to update.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Core.Feature"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var feature = new Feature();
		///   var feature = feature.UpdateActiveRateProviders( activeRateProviders);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.Core.Feature> UpdateActiveRateProviders(List<Mozu.Api.Contracts.Core.Feature> activeRateProviders)
		{
						MozuClient<List<Mozu.Api.Contracts.Core.Feature>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Shipping.FeatureClient.UpdateActiveRateProvidersClient( activeRateProviders);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				
	}

}

