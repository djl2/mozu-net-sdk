
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Shipping.Instance
{
	/// <summary>
	/// Configure the shipping carrier for the site.
	/// </summary>
	public partial class InstanceCarrierClient 	{
		
		/// <summary>
		/// Retrieves a list of carrier configurations according to any specified filter criteria and sort options.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetConfigurations();
		///   var carrierConfigurationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection> GetConfigurationsClient()
		{
			return GetConfigurationsClient( null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of carrier configurations according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">Specifies the number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetConfigurations( filter,  pageSize,  sortBy,  startIndex);
		///   var carrierConfigurationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection> GetConfigurationsClient(string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Shipping.Instance.InstanceCarrierUrl.GetConfigurationsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfigurationCollection>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		/// <summary>
		/// Retrieves the carrier configuration for a specific site by providing the carrier ID.
		/// </summary>
		/// <param name="carrierId">Identifier of the shipping carrier associated with the configuration details to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetConfiguration( carrierId);
		///   var carrierConfigurationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> GetConfigurationClient(string carrierId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Shipping.Instance.InstanceCarrierUrl.GetConfigurationUrl(carrierId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

				/// <summary>
		/// Create a new carrier configuration for the site.
		/// </summary>
		/// <param name="carrierId">Identifier of the carrier configuration being created.</param>
		/// <param name="carrierConfiguration">The properties of the carrier configuration to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateConfiguration( carrierId,  carrierConfiguration);
		///   var carrierConfigurationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> CreateConfigurationClient(string carrierId, Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration carrierConfiguration)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Shipping.Instance.InstanceCarrierUrl.CreateConfigurationUrl(carrierId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration>(carrierConfiguration);
		return mozuClient;

		}

				/// <summary>
		/// Update and existing shipping carrier configuration.
		/// </summary>
		/// <param name="carrierId">Identifier of the shipping carrier configuration to update.</param>
		/// <param name="carrierConfiguration">The properties of the shipping carrier configuration to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateConfiguration( carrierId,  carrierConfiguration);
		///   var carrierConfigurationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration> UpdateConfigurationClient(string carrierId, Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration carrierConfiguration)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Shipping.Instance.InstanceCarrierUrl.UpdateConfigurationUrl(carrierId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ShippingAdmin.CarrierConfiguration>(carrierConfiguration);
		return mozuClient;

		}

				/// <summary>
		/// Delete the shipping carrier for the site.
		/// </summary>
		/// <param name="carrierId">Identifier of the specific shipping carrier to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteConfiguration( carrierId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteConfigurationClient(string carrierId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Shipping.Instance.InstanceCarrierUrl.DeleteConfigurationUrl(carrierId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

		
	}

}


