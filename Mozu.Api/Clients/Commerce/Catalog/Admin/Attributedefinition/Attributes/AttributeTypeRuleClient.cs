
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


namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// Type rules are subresources of product attributes which could be specifications that can be shared across products in a store or assigned to specific products. Attribute type rules provide definitions of how attribute types will appear on the user interface.
	/// </summary>
	public partial class AttributeTypeRuleClient 	{
		
		/// <summary>
		/// Retrieves a list of attribute type rules according to optional filter criteria and sort options. Attribute type rules help drive the behavior of attributes on a storefront page.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeTypeRules(dataViewMode);
		///   var attributeTypeRuleCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection> GetAttributeTypeRulesClient(DataViewMode dataViewMode)
		{
			return GetAttributeTypeRulesClient(dataViewMode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// Retrieves a list of attribute type rules according to optional filter criteria and sort options. Attribute type rules help drive the behavior of attributes on a storefront page.
		/// </summary>
		/// <param name="filter">"A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - ""filter=IsDisplayed+eq+true"""</param>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeTypeRules(dataViewMode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
		///   var attributeTypeRuleCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection> GetAttributeTypeRulesClient(DataViewMode dataViewMode, string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeTypeRuleUrl.GetAttributeTypeRulesUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

								
	}

}


