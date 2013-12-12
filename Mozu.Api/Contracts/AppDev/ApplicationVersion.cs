
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

namespace Mozu.Api.Contracts.AppDev
{
		///
		///	Properties of a specific version of an application.
		///
		public class ApplicationVersion
		{
			///
			///Unique identifier of the application version.
			///
			public int Id { get; set; }

			///
			///The name of the application version.
			///
			public string Name { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Properties of a development package of files for an application version.
			///
			public List<Package> DevPackages { get; set; }

			///
			///Properties of a releasable package of files for an application version.
			///
			public Package ReleasePackage { get; set; }

		}

}