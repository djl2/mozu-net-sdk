
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Mozu.Api.Security;


namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// 
	/// </summary>
	public partial class OrderValidationResultResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public OrderValidationResultResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var ordervalidationresult = new OrderValidationResult();
		///   var orderValidationResult = ordervalidationresult.GetValidationResults( orderId);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult> GetValidationResults(string orderId)
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderValidationResultClient.GetValidationResultsClient( orderId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="validationResult"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordervalidationresult = new OrderValidationResult();
		///   var orderValidationResult = ordervalidationresult.AddValidationResult( validationResult,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult AddValidationResult(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult validationResult, string orderId)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderValidationResult> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderValidationResultClient.AddValidationResultClient( validationResult,  orderId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


