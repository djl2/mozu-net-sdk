
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
using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.Core.ThirdParty;
using Mozu.Api.Contracts.Tenant;

namespace Mozu.Api.Contracts.SiteSettings.Application
{
		///
		///	Properties of an application installed in a tenant.
		///
		public class Application
		{
			///
			///The unique identifier of the application in Mozu Dev Center.
			///
			public string AppId { get; set; }

			///
			///If true, the application is enabled for the tenant. System-supplied and read-only.
			///
			public bool? Enabled { get; set; }

			///
			///If true, the third party application settings have been configured and the application is initialized.
			///
			public bool? Initialized { get; set; }

			public bool? IsExtension { get; set; }

			///
			///URL of the application's setting configuration user interface, supplied by the capability developer in Dev Center.
			///
			public string UiConfigurationUrl { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///List of capabilities installed in a tenant.
			///
			public List<Capability> Capabilities { get; set; }

			///
			///Properties of the application entitlement record, including the merchant it is licensed to and the duration of the license.
			///
			public Entitlement Entitlement { get; set; }

		}

}