
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


namespace Mozu.Api.Resources.Commerce.Settings
{
	/// <summary>
	/// Define global site settings such as the site name, shipping and email addresses, and logo images. Block undesirable IP addresses using this resource.
	/// </summary>
	public partial class GeneralSettingsResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public GeneralSettingsResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieve a site's general global settings.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.GeneralSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var generalsettings = new GeneralSettings();
		///   var generalSettings = generalsettings.GetGeneralSettings(authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.General.GeneralSettings GetGeneralSettings(AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.GeneralSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.GeneralSettingsClient.GetGeneralSettingsClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates a site's general global settings.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="generalSettings">The properties of the site's general settings to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.GeneralSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var generalsettings = new GeneralSettings();
		///   var generalSettings = generalsettings.UpdateGeneralSettings( generalSettings, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.General.GeneralSettings UpdateGeneralSettings(Mozu.Api.Contracts.SiteSettings.General.GeneralSettings generalSettings, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.GeneralSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.GeneralSettingsClient.UpdateGeneralSettingsClient( generalSettings, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


