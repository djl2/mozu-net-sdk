
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Categories resource to organize products and control where they appear on the storefront. Create and maintain a hierarchy of categories and subcategories where the site will store properties.
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
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = category.GetCategories(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection GetCategories(DataViewMode dataViewMode)
		{
			return GetCategories(dataViewMode,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of categories according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. You can filter product category search results by any of its properties, including its position in the category hierarchy. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryPagedCollection = category.GetCategories(dataViewMode,  startIndex,  pageSize,  sortBy,  filter);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection GetCategories(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetCategoriesClient(dataViewMode,  startIndex,  pageSize,  sortBy,  filter);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of a single category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to retrieve.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.GetCategory(dataViewMode,  categoryId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Category GetCategory(DataViewMode dataViewMode, int categoryId)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetCategoryClient(dataViewMode,  categoryId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the subcategories of a category. This is a list of subcategories at the same level (siblings). Use a list of siblings, for example, to display the categories in a horizontal list.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category whose subcategories are retrieved.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.CategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var categoryCollection = category.GetChildCategories(dataViewMode,  categoryId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.CategoryCollection GetChildCategories(DataViewMode dataViewMode, int categoryId)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.CategoryCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.GetChildCategoriesClient(dataViewMode,  categoryId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Adds a new category to the site's category hierarchy. Specify a ParentCategoryID to determine where to locate the category in the hierarchy. If a ParentCategoryID is not specified, the new category becomes a top-level category.
		/// </summary>
		/// <param name="category">Properties of the new category. Required properties: ParentCategoryID and Content.Name.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.AddCategory(dataViewMode,  category);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Category AddCategory(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Category category)
		{
			return AddCategory(dataViewMode,  category,  null);
		}

		/// <summary>
		/// Adds a new category to the site's category hierarchy. Specify a ParentCategoryID to determine where to locate the category in the hierarchy. If a ParentCategoryID is not specified, the new category becomes a top-level category.
		/// </summary>
		/// <param name="incrementSequence"></param>
		/// <param name="category">Properties of the new category. Required properties: ParentCategoryID and Content.Name.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.AddCategory(dataViewMode,  category,  incrementSequence);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Category AddCategory(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Category category, bool? incrementSequence =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.AddCategoryClient(dataViewMode,  category,  incrementSequence);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Modifies a category such as moving it to another location in the category tree, or changing whether it is visible on the storefront. This PUT replaces the existing resource, so be sure to include all the information to maintain for the category.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="category">Properties of the category to modify.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.UpdateCategory(dataViewMode,  category,  categoryId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Category UpdateCategory(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Category category, int categoryId)
		{
			return UpdateCategory(dataViewMode,  category,  categoryId,  null);
		}

		/// <summary>
		/// Modifies a category such as moving it to another location in the category tree, or changing whether it is visible on the storefront. This PUT replaces the existing resource, so be sure to include all the information to maintain for the category.
		/// </summary>
		/// <param name="cascadeVisibility">If true, when changing the display option for the category, change it for all subcategories also. Default: False.</param>
		/// <param name="categoryId">Unique identifier of the category to modify.</param>
		/// <param name="category">Properties of the category to modify.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Category"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   var category = category.UpdateCategory(dataViewMode,  category,  categoryId,  cascadeVisibility);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.Category UpdateCategory(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.Category category, int categoryId, bool? cascadeVisibility =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Category> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.UpdateCategoryClient(dataViewMode,  category,  categoryId,  cascadeVisibility);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Deletes the category specified by its category ID.
		/// </summary>
		/// <param name="categoryId">Unique identifier of the category to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   category.DeleteCategoryById(dataViewMode,  categoryId);
		/// </code>
		/// </example>
		public virtual void DeleteCategoryById(DataViewMode dataViewMode, int categoryId)
		{
			DeleteCategoryById(dataViewMode,  categoryId,  null);
		}

		/// <summary>
		/// Deletes the category specified by its category ID.
		/// </summary>
		/// <param name="cascadeDelete">If true, any subcategories of a category are deleted when this category is deleted. Default: False.</param>
		/// <param name="categoryId">Unique identifier of the category to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var category = new Category();
		///   category.DeleteCategoryById(dataViewMode,  categoryId,  cascadeDelete);
		/// </code>
		/// </example>
		public virtual void DeleteCategoryById(DataViewMode dataViewMode, int categoryId, bool? cascadeDelete =  null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.CategoryClient.DeleteCategoryByIdClient(dataViewMode,  categoryId,  cascadeDelete);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


