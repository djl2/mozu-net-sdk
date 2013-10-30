
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

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// Use the tenants resource to manage information about a Mozu tenant.
	/// </summary>
	public partial class TenantClient 	{
		
		/// <summary>
		/// Retrieve details about a specific tenant by providing the tenant ID.
		/// </summary>
		/// <param name="tenantId">Unique identifier of the Mozu tenant.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Tenant.Tenant"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetTenant( tenantId);
		///   var tenantClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Tenant.Tenant> GetTenantClient(int tenantId)
		{
			var url = Mozu.Api.Urls.Platform.TenantUrl.GetTenantUrl(tenantId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Tenant.Tenant>().WithVerb(verb).WithResourceUrl(url);
		return mozuClient;

		}

								
	}

}


