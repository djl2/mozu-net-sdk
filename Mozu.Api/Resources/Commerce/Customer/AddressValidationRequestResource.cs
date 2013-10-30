
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

namespace Mozu.Api.Resources.Commerce.Customer
{
	/// <summary>
	/// 
	/// </summary>
	public partial class AddressValidationRequestResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public AddressValidationRequestResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
				/// <summary>
		/// 
		/// </summary>
		/// <param name="addressValidationRequest"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.AddressValidationResponse"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var addressvalidationrequest = new AddressValidationRequest();
		///   var addressValidationResponse = addressvalidationrequest.ValidateAddress( addressValidationRequest);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Customer.AddressValidationResponse ValidateAddress(Mozu.Api.Contracts.Customer.AddressValidationRequest addressValidationRequest)
		{
						MozuClient<Mozu.Api.Contracts.Customer.AddressValidationResponse> response;
			var client = Mozu.Api.Clients.Commerce.Customer.AddressValidationRequestClient.ValidateAddressClient( addressValidationRequest);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

						
	}

}


