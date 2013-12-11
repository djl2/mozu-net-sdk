
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
		///	Properties of the customer account.
		///
		public class CustomerAccount
		{
			///
			///If true, the customer prefers to receive marketing material such as newsletters or email offers.
			///
			public bool AcceptsMarketing { get; set; }

			///
			///The legal or doing business as (DBA) or tradestyle name of the business or organization. The maximum character length is 200.
			///
			public string CompanyOrOrganization { get; set; }

			public string EmailAddress { get; set; }

			public string ExternalId { get; set; }

			public string FirstName { get; set; }

			///
			///Identifier of the entity.
			///
			public int Id { get; set; }

			public string LastName { get; set; }

			public string LocaleCode { get; set; }

			///
			///If true, this customer account has tax exempt status.
			///
			public bool TaxExempt { get; set; }

			///
			///The tax identification number associated with the customer account.
			///
			public string TaxId { get; set; }

			///
			///Unique identifier of the user associated with the customer account.
			///
			public string UserId { get; set; }

			public string UserName { get; set; }

			///
			///Collection of customer account attributes.
			///
			public List<CustomerAttribute> Attributes { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Properties of the commerce summary associated with a customer account, which includes details about the shopper's most recent order, wish lists, and total order value over time.
			///
			public CommerceSummary CommerceSummary { get; set; }

			///
			///Contact information, including the contact's name, address, phone numbers, email addresses, and company (if supplied). Also indicates whether this is a billing, shipping, or billing and shipping contact.
			///
			public List<CustomerContact> Contacts { get; set; }

			///
			///List of groups associated with this customer account.
			///
			public List<CustomerGroup> Groups { get; set; }

			///
			///List of customer account notes.
			///
			public List<CustomerNote> Notes { get; set; }

		}

}