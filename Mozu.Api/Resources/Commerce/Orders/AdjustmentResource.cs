
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use this subresource to manage ad-hoc order level price adjustments.
	/// </summary>
	public partial class AdjustmentResource : BaseResource 	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly ApiContext _apiContext;
		public AdjustmentResource(ApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
						/// <summary>
		/// Modify the amount charged for shipping the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the shipping adjustment.</param>
		/// <param name="adjustment">Properties of the shipping adjustment to apply to the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.ApplyShippingAdjustment( orderId,  adjustment);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyShippingAdjustment(string orderId, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment)
		{
			return ApplyShippingAdjustment( orderId,  null,  null,  adjustment);
		}

		/// <summary>
		/// Modify the amount charged for shipping the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order associated with the shipping adjustment.</param>
		/// <param name="updateMode">Specifies whether to apply the shipping adjustment by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version">If applicable, the version of the order or draft to which to apply the shipping adjustment.</param>
		/// <param name="adjustment">Properties of the shipping adjustment to apply to the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.ApplyShippingAdjustment( orderId,  updateMode,  version,  adjustment);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyShippingAdjustment(string orderId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.ApplyShippingAdjustmentClient( orderId,  updateMode,  version,  adjustment);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Applies a price adjustment to the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to apply the adjustment.</param>
		/// <param name="adjustment">Properties of the price adjustment to apply to the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.ApplyAdjustment( orderId,  adjustment);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyAdjustment(string orderId, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment)
		{
			return ApplyAdjustment( orderId,  null,  null,  adjustment);
		}

		/// <summary>
		/// Applies a price adjustment to the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to apply the adjustment.</param>
		/// <param name="updateMode">Specifies whether to apply the adjustment by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version">If applicable, the version of the order or draft for which to apply the adjustment.</param>
		/// <param name="adjustment">Properties of the price adjustment to apply to the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.ApplyAdjustment( orderId,  updateMode,  version,  adjustment);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order ApplyAdjustment(string orderId, string updateMode, string version, Mozu.Api.Contracts.CommerceRuntime.Commerce.Adjustment adjustment)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.ApplyAdjustmentClient( orderId,  updateMode,  version,  adjustment);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Removes a shipping adjustment previously applied to an order or draft.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the applied shipping adjustment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.RemoveShippingAdjustment( orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveShippingAdjustment(string orderId)
		{
			return RemoveShippingAdjustment( orderId,  null,  null);
		}

		/// <summary>
		/// Removes a shipping adjustment previously applied to an order or draft.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order with the applied shipping adjustment.</param>
		/// <param name="updateMode">Specifies whether to remove the shipping adjustment by updating the original order, updating the order in draft mode, or updating the order in draft mode and then commit the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version">If applicable, the version of the order or draft from which to remove the shipping adjustment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.RemoveShippingAdjustment( orderId,  updateMode,  version);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveShippingAdjustment(string orderId, string updateMode, string version)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.RemoveShippingAdjustmentClient( orderId,  updateMode,  version);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Removes a price adjustment from the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to delete the adjustment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.RemoveAdjustment( orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveAdjustment(string orderId)
		{
			return RemoveAdjustment( orderId,  null,  null);
		}

		/// <summary>
		/// Removes a price adjustment from the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order for which to delete the adjustment.</param>
		/// <param name="updateMode">Specifies whether to remove the adjustment by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal", "ApplyToDraft", or "ApplyAndCommit".</param>
		/// <param name="version">If applicable, the version of the order or draft from which to remove the adjustment.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.Order"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var adjustment = new Adjustment();
		///   var order = adjustment.RemoveAdjustment( orderId,  updateMode,  version);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Orders.Order RemoveAdjustment(string orderId, string updateMode, string version)
		{
						MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.Order> response;
			var client = Mozu.Api.Clients.Commerce.Orders.AdjustmentClient.RemoveAdjustmentClient( orderId,  updateMode,  version);
			SetContext(_apiContext, ref client,true);
			response= client.Execute();
			return response.Result();

		}

		
	}

}


