
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

namespace Mozu.Api.Contracts.Tenant
{
		///
		///	Properties of a tenant, which the logical grouping of all a company's sites and catalogs.
		///
		public class Tenant
		{
			///
			///The domain information associated with the tenant.
			///
			public string Domain { get; set; }

			///
			///Unique identifier of the Mozu tenant.
			///
			public int Id { get; set; }

			///
			///If true, the tenant represents a collection of master catalogs and catalogs for a development tenant, used by a developer account to test applications and themes.
			///
			public bool IsDevTenant { get; set; }

			///
			///The name of the tenant.
			///
			public string Name { get; set; }

			///
			///Collection of master catalogs associated with the tenant.
			///
			public List<MasterCatalog> MasterCatalogs { get; set; }

			///
			///Collection of sites associated with the tenant.
			///
			public List<Site> Sites { get; set; }

		}

}