
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Discounts
{
	/// <summary>
	/// 
	/// </summary>
	public partial class DiscountTargetResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public DiscountTargetResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discounttarget = new DiscountTarget();
		///   var discountTarget = discounttarget.GetDiscountTarget(dataViewMode,  discountId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountTarget GetDiscountTarget(DataViewMode dataViewMode, int discountId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.GetDiscountTargetClient(dataViewMode,  discountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

						/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="discountTarget"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.DiscountTarget"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var discounttarget = new DiscountTarget();
		///   var discountTarget = discounttarget.UpdateDiscountTarget(dataViewMode,  discountTarget,  discountId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.DiscountTarget UpdateDiscountTarget(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.DiscountTarget discountTarget, int discountId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.DiscountTarget> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Discounts.DiscountTargetClient.UpdateDiscountTargetClient(dataViewMode,  discountTarget,  discountId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				
	}

}


