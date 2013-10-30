
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

namespace Mozu.Api.Clients.Commerce.Settings.Shipping
{
	/// <summary>
	/// Use the active rate providers subresource to manage entities that provide estimated shipping rate calculations. Active rate providers represent carrier configurations set up in the shipping admin service.
	/// </summary>
	public partial class FeatureClient 	{
		
		/// <summary>
		/// Retrieves a list of the active rate providers configured for the site.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Core.Feature"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetActiveRateProviders();
		///   var featureClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Core.Feature>> GetActiveRateProvidersClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Shipping.FeatureUrl.GetActiveRateProvidersUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Core.Feature>>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

				/// <summary>
		/// Creates a new active rate provider for the site.
		/// </summary>
		/// <param name="activeRateProvider">Properties of the active rate provider to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.Feature"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddActiveRateProvider( activeRateProvider);
		///   var featureClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.Feature> AddActiveRateProviderClient(Mozu.Api.Contracts.Core.Feature activeRateProvider)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Shipping.FeatureUrl.AddActiveRateProviderUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.Feature>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Core.Feature>(activeRateProvider);
		return mozuClient;

		}

				/// <summary>
		/// Updates the active rate providers configured for the site.
		/// </summary>
		/// <param name="activeRateProviders">Properties of the active rate provider to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Core.Feature"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateActiveRateProviders( activeRateProviders);
		///   var featureClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Core.Feature>> UpdateActiveRateProvidersClient(List<Mozu.Api.Contracts.Core.Feature> activeRateProviders)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Shipping.FeatureUrl.UpdateActiveRateProvidersUrl();
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Core.Feature>>().WithVerb(verb).WithResourceUrl(url).WithBody<List<Mozu.Api.Contracts.Core.Feature>>(activeRateProviders);
		return mozuClient;

		}

				
	}

}


