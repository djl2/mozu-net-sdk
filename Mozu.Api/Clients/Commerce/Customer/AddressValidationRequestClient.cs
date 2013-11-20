
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
using Mozu.Api.Security;


namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// 
	/// </summary>
	public partial class AddressValidationRequestClient 	{
		
				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="addressValidationRequest"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.AddressValidationResponse"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ValidateAddress( addressValidationRequest, authTicket);
		///   var addressValidationResponseClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.AddressValidationResponse> ValidateAddressClient(Mozu.Api.Contracts.Customer.AddressValidationRequest addressValidationRequest, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.AddressValidationRequestUrl.ValidateAddressUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.AddressValidationResponse>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Customer.AddressValidationRequest>(addressValidationRequest);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

						
	}

}


