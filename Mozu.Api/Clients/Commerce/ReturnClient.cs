
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


namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// Use the returns subresource to manage returned items that were previously fufilled. Returns can include any number of items associated with an original Mozu order. Each return must either be associated with an original order or a product definition to represent each returned item.
	/// </summary>
	public partial class ReturnClient 	{
		
		/// <summary>
		/// Retrieves a list of all returns according to any filter and sort criteria.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturns();
		///   var returnCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> GetReturnsClient()
		{
			return GetReturnsClient( null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of all returns according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturns( startIndex,  pageSize,  sortBy,  filter, authTicket);
		///   var returnCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> GetReturnsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of properties for the specified return.
		/// </summary>
		/// <param name="returnId">Returns the properties of the return specified in the request as well as system-supplied information.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetReturn( returnId, authTicket);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> GetReturnClient(string returnId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetReturnUrl(returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of the actions available to perform for the specified return based on its current state.
		/// </summary>
		/// <param name="returnId">Retrieves a list of the actions available to perform for the specified return based on its current state.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailableReturnActions( returnId, authTicket);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailableReturnActionsClient(string returnId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetAvailableReturnActionsUrl(returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of all payments submitted as part of a refund associated with a customer return.
		/// </summary>
		/// <param name="returnId">Returns the details of the refund payment associated with the return specified in the request.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayments( returnId, authTicket);
		///   var paymentCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection> GetPaymentsClient(string returnId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetPaymentsUrl(returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of a payment submitted as part of a refund associated with a customer return.
		/// </summary>
		/// <param name="paymentId">Unique identifier of the return payment to retrieve.</param>
		/// <param name="returnId">Unique identifier of the return associated with the payment.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.Payment"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetPayment( returnId,  paymentId, authTicket);
		///   var paymentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment> GetPaymentClient(string returnId, string paymentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetPaymentUrl(paymentId, returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.Payment>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of the payment actions available to perform for the specified return when a return results in a refund to the customer.
		/// </summary>
		/// <param name="paymentId">Unique identifier of the payment for which to perform the action.</param>
		/// <param name="returnId">Unique identifier of the return associated with the payment.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{string}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAvailablePaymentActionsForReturn( returnId,  paymentId, authTicket);
		///   var stringClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<string>> GetAvailablePaymentActionsForReturnClient(string returnId, string paymentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.GetAvailablePaymentActionsForReturnUrl(paymentId, returnId);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<string>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Creates a return for previously fulfilled items. Each return must either be associated with an original order or a product definition to represent each returned item.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="ret">Wrapper for the properties of the return to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateReturn( ret, authTicket);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreateReturnClient(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreateReturnUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>(ret);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Updates a refund payment associated with a customer return by performing the specified action.
		/// </summary>
		/// <param name="paymentId">Unique identifier of the return payment to update.</param>
		/// <param name="returnId">Unique identifier of the return associated with the refund payment.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action">The payment action to perform for the refund payment.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformPaymentActionForReturn( action,  returnId,  paymentId, authTicket);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> PerformPaymentActionForReturnClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, string paymentId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.PerformPaymentActionForReturnUrl(paymentId, returnId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Creates a new payment for a return that results in a refund to the customer.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return associated with the payment action.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action">The payment action to perform for the customer return.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreatePaymentActionForReturn( action,  returnId, authTicket);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> CreatePaymentActionForReturnClient(Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction action, string returnId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.CreatePaymentActionForReturnUrl(returnId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Payments.PaymentAction>(action);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Updates the return by performing the specified action.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="action">The name of the return action to perform, such as "Refund" or "Replace".</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PerformReturnActions( action, authTicket);
		///   var returnCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection> PerformReturnActionsClient(Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction action, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.PerformReturnActionsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnCollection>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.ReturnAction>(action);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of a return for items previously shipped in a completed order.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="ret">Wrapper for the array of properties to update for the return.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Returns.Return"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateReturn( ret,  returnId, authTicket);
		///   var returnClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return> UpdateReturnClient(Mozu.Api.Contracts.CommerceRuntime.Returns.Return ret, string returnId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.UpdateReturnUrl(returnId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Returns.Return>(ret);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the return specified in the request.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return to delete.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteReturn( returnId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteReturnClient(string returnId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ReturnUrl.DeleteReturnUrl(returnId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}


	}

}


