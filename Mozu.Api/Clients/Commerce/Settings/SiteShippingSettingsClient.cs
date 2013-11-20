
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


namespace Mozu.Api.Clients.Commerce.Settings
{
	/// <summary>
	/// Use the shipping subresource to manage settings for the site shipping information, such as origin address information, carrier shipping methods, shipping rate providers, and regions available for shipping.
	/// </summary>
	public partial class SiteShippingSettingsClient 	{
		
		/// <summary>
		/// Retrieves a list of the shipping settings configured for a site.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetSiteShippingSettings(authTicket);
		///   var siteShippingSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingSettings> GetSiteShippingSettingsClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.SiteShippingSettingsUrl.GetSiteShippingSettingsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Shipping.SiteShippingSettings>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

								
	}

}


