
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
using Mozu.Api.Contracts.Tenant;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.AdminUser
{
		public class TenantAdminUserAuthTicket
		{
			public string AccessToken { get; set; }

			public DateTime AccessTokenExpiration { get; set; }

			public DateTime CreatedOn { get; set; }

			public List<int> GrantedBehaviors { get; set; }

			public string RefreshToken { get; set; }

			public DateTime RefreshTokenExpiration { get; set; }

			public List<Tenant.Tenant> AvailableTenants { get; set; }

			public Tenant.Tenant Tenant { get; set; }

			public UserProfile User { get; set; }

		}

}