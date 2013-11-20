
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


namespace Mozu.Api.Clients.Commerce.Settings.Checkout
{
	/// <summary>
	/// Specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsClient 	{
		
		/// <summary>
		/// Retrieves a list of the payment settings for the specified site.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPaymentSettings(authTicket);
		///   var paymentSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings> GetPaymentSettingsClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetPaymentSettingsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetActiveGatewayForCountry( countryCode, authTicket);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> GetActiveGatewayForCountryClient(string countryCode, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetActiveGatewayForCountryUrl(countryCode);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.PaymentService.GatewayDefinition"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetGatewayDefinitions(authTicket);
		///   var gatewayDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.PaymentService.GatewayDefinition>> GetGatewayDefinitionsClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetGatewayDefinitionsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.PaymentService.GatewayDefinition>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="gatewayId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetGateway( gatewayId, authTicket);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> GetGatewayClient(string gatewayId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetGatewayUrl(gatewayId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetThirdPartyPaymentWorkflows(authTicket);
		///   var externalPaymentWorkflowDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>> GetThirdPartyPaymentWorkflowsClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetThirdPartyPaymentWorkflowsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.SiteSettings.Order.ExternalPaymentWorkflowDefinition>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="gateway"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateGateway( gateway, authTicket);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> CreateGatewayClient(Mozu.Api.Contracts.SiteSettings.Order.Gateway gateway, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.CreateGatewayUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.SiteSettings.Order.Gateway>(gateway);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// Updates one or more properties in the configured payment settings for a site.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="paymentSettings">Properties of the payment settings to use for the site.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePaymentSettings( paymentSettings, authTicket);
		///   var paymentSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings> UpdatePaymentSettingsClient(Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings paymentSettings, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.UpdatePaymentSettingsUrl();
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings>(paymentSettings);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="gatewayId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="gateway"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateGateway( gateway,  gatewayId, authTicket);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> UpdateGatewayClient(Mozu.Api.Contracts.SiteSettings.Order.Gateway gateway, string gatewayId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.UpdateGatewayUrl(gatewayId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.SiteSettings.Order.Gateway>(gateway);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				
	}

}


