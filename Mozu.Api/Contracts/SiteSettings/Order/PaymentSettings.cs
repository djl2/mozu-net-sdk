
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

namespace Mozu.Api.Contracts.SiteSettings.Order
{
		///
		///	Properties of the payment settings used at order checkout time for the site.
		///
		public class PaymentSettings
		{
			///
			///Settings that provide for the ability to pay for an order by mail.
			///
			public bool PayByMail { get; set; }

			///
			///Identifier and datetime stamp information recorded when creating or updating a resource entity. System-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			public List<ExternalPaymentWorkflowDefinition> ExternalPaymentWorkflowDefinitions { get; set; }

			///
			///List of name and account information for a payment gateway. Additional payment gateway providers will be supported in future releases.
			///
			public List<Gateway> Gateways { get; set; }

		}

}