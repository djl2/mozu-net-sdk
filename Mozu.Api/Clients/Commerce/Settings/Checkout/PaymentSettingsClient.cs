
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

namespace Mozu.Api.Clients.Commerce.Settings.Checkout
{
	/// <summary>
	/// Specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsClient 	{
		
		/// <summary>
		/// Retrieves a list of the payment settings for the specified site.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPaymentSettings();
		///   var paymentSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings> GetPaymentSettingsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetPaymentSettingsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetActiveGatewayForCountry( countryCode);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> GetActiveGatewayForCountryClient(string countryCode)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetActiveGatewayForCountryUrl(countryCode);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.PaymentService.GatewayDefinition"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetGatewayDefinitions();
		///   var gatewayDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.PaymentService.GatewayDefinition>> GetGatewayDefinitionsClient()
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetGatewayDefinitionsUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.PaymentService.GatewayDefinition>>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="gatewayId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetGateway( gatewayId);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> GetGatewayClient(string gatewayId)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.GetGatewayUrl(gatewayId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="gateway"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateGateway( gateway);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> CreateGatewayClient(Mozu.Api.Contracts.SiteSettings.Order.Gateway gateway)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.CreateGatewayUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.SiteSettings.Order.Gateway>(gateway);
		return mozuClient;

		}

				/// <summary>
		/// Updates one or more properties in the configured payment settings for a site.
		/// </summary>
		/// <param name="paymentSettings">Properties of the payment settings to use for the site.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdatePaymentSettings( paymentSettings);
		///   var paymentSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings> UpdatePaymentSettingsClient(Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings paymentSettings)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.UpdatePaymentSettingsUrl();
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings>(paymentSettings);
		return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="gatewayId"></param>
		/// <param name="gateway"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateGateway( gatewayId,  gateway);
		///   var gatewayClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> UpdateGatewayClient(string gatewayId, Mozu.Api.Contracts.SiteSettings.Order.Gateway gateway)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.Checkout.PaymentSettingsUrl.UpdateGatewayUrl(gatewayId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.SiteSettings.Order.Gateway>(gateway);
		return mozuClient;

		}

				
	}

}

