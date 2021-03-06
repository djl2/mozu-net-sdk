
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// Type rules are subresources of product attributes which could be specifications that can be shared across products in a store or assigned to specific products. Attribute type rules provide definitions of how attribute types will appear on the user interface.
	/// </summary>
	public partial class AttributeTypeRuleResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public AttributeTypeRuleResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of attribute type rules according to optional filter criteria and sort options. Attribute type rules help drive the behavior of attributes on a storefront page.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributetyperule = new AttributeTypeRule();
		///   var attributeTypeRuleCollection = attributetyperule.GetAttributeTypeRules(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection GetAttributeTypeRules(DataViewMode dataViewMode)
		{
			return GetAttributeTypeRules(dataViewMode,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of attribute type rules according to optional filter criteria and sort options. Attribute type rules help drive the behavior of attributes on a storefront page.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var attributetyperule = new AttributeTypeRule();
		///   var attributeTypeRuleCollection = attributetyperule.GetAttributeTypeRules(dataViewMode,  startIndex,  pageSize,  sortBy,  filter);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection GetAttributeTypeRules(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeTypeRuleClient.GetAttributeTypeRulesClient(dataViewMode,  startIndex,  pageSize,  sortBy,  filter);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


