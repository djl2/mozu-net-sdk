
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

namespace Mozu.Api.Contracts.Customer
{
		///
		///	Properties of an attribute associated with a customer account.
		///
		public class CustomerAttribute
		{
			///
			///Unique identifier of the attribute definition.
			///
			public int AttributeDefinitionId { get; set; }

			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string FullyQualifiedName { get; set; }

			///
			///List of values for the attribute.
			///
			public List<object> Values { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}