
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

namespace Mozu.Api.Contracts.Customer
{
		///
		///	A set of customers.
		///
		public class CustomerGroup
		{
			///
			///Identifier of the entity.
			///
			public int Id { get; set; }

			///
			///Name of the customer group.
			///
			public string Name { get; set; }

			///
			///Identifier and datetime stamp information recorded when creating or updating a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

		}

}