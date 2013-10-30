
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

namespace Mozu.Api.Resources.Commerce.Settings.Checkout
{
	/// <summary>
	/// Specify settings when creating payments for order checkout on the site.
	/// </summary>
	public partial class PaymentSettingsResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public PaymentSettingsResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of the payment settings for the specified site.
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var paymentSettings = paymentsettings.GetPaymentSettings();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings GetPaymentSettings()
		{
						MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetPaymentSettingsClient();
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var gateway = paymentsettings.GetActiveGatewayForCountry( countryCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.Order.Gateway GetActiveGatewayForCountry(string countryCode)
		{
						MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetActiveGatewayForCountryClient( countryCode);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.PaymentService.GatewayDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var gatewayDefinition = paymentsettings.GetGatewayDefinitions();
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.PaymentService.GatewayDefinition> GetGatewayDefinitions()
		{
						MozuClient<List<Mozu.Api.Contracts.PaymentService.GatewayDefinition>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetGatewayDefinitionsClient();
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="gatewayId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var gateway = paymentsettings.GetGateway( gatewayId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.Order.Gateway GetGateway(string gatewayId)
		{
						MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.GetGatewayClient( gatewayId);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="gateway"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var gateway = paymentsettings.CreateGateway( gateway);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.Order.Gateway CreateGateway(Mozu.Api.Contracts.SiteSettings.Order.Gateway gateway)
		{
						MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.CreateGatewayClient( gateway);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Updates one or more properties in the configured payment settings for a site.
		/// </summary>
		/// <param name="paymentSettings">Properties of the payment settings to use for the site.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var paymentSettings = paymentsettings.UpdatePaymentSettings( paymentSettings);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings UpdatePaymentSettings(Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings paymentSettings)
		{
						MozuClient<Mozu.Api.Contracts.SiteSettings.Order.PaymentSettings> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.UpdatePaymentSettingsClient( paymentSettings);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="gatewayId"></param>
		/// <param name="gateway"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.Order.Gateway"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var paymentsettings = new PaymentSettings();
		///   var gateway = paymentsettings.UpdateGateway( gatewayId,  gateway);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.SiteSettings.Order.Gateway UpdateGateway(string gatewayId, Mozu.Api.Contracts.SiteSettings.Order.Gateway gateway)
		{
						MozuClient<Mozu.Api.Contracts.SiteSettings.Order.Gateway> response;
			var client = Mozu.Api.Clients.Commerce.Settings.Checkout.PaymentSettingsClient.UpdateGatewayClient( gatewayId,  gateway);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				
	}

}

