
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


namespace Mozu.Api.Resources.Commerce.Catalog.Storefront
{
	/// <summary>
	/// Get the product category hierarchy as it appears to shoppers who are browsing the storefront. The hierarchy can be returned as a flat list or as a category tree.
	/// </summary>
	public partial class CategoryResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public CategoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = category.GetCategories();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection GetCategories()
		{
			return GetCategories( null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product category search results by any of its properties, including its position in the category hierarchy. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). <b>For example - "filter=IsDisplayed+eq+true"</b></param>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = category.GetCategories( filter,  pageSize,  sortBy,  startIndex, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection GetCategories(string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoriesClient( filter,  pageSize,  sortBy,  startIndex, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="categoryId">Unique identifier for the storefront container used to organize products.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.GetCategory( categoryId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductRuntime.Category GetCategory(int categoryId)
		{
			return GetCategory( categoryId,  null, null);
		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="allowInactive">If true, allow inactive categories to be retrieved in the category list response. If false, the categories retrieved will not include ones marked inactive.</param>
		/// <param name="categoryId">Unique identifier for the storefront container used to organize products.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.GetCategory( categoryId,  allowInactive, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductRuntime.Category GetCategory(int categoryId, bool? allowInactive =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryClient( categoryId,  allowInactive, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the list of product categories that appear on the storefront organized in a hierarchical format. Hidden categories do not appear in the list.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductRuntime.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = category.GetCategoryTree(authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductRuntime.CategoryCollection GetCategoryTree(AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductRuntime.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Storefront.CategoryClient.GetCategoryTreeClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

								
	}

}


