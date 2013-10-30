
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.AppDev
{
		///
		///	Properties if the namespace registry for third party applications.
		///
		public class NamespaceRegistry
		{
			///
			///Abbreviation for the namespace, which is optional and does not need to be unique.
			///
			public string Abbreviation { get; set; }

			///
			///Unique identifier of the application associated with the namespace registry. Not all namespaces must be associated with an application.
			///
			public int? ApplicationId { get; set; }

			///
			///The full namespace required by the application.
			///
			public string FullNamespace { get; set; }

			///
			///Unique identifier of the namespace registry item.
			///
			public int NamespaceRegistryId { get; set; }

			///
			///Identifier and datetime stamp information recorded when creating or updating a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}