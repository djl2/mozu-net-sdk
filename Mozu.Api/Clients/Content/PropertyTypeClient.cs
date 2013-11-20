
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


namespace Mozu.Api.Clients.Content
{
	/// <summary>
	/// Use the property types subresource to manage content properties.
	/// </summary>
	public partial class PropertyTypeClient 	{
		
		/// <summary>
		/// Retrieve a list of the content property types.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.PropertyTypeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetList();
		///   var propertyTypeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.PropertyTypeCollection> GetListClient()
		{
			return GetListClient( null,  null, null);
		}

		/// <summary>
		/// Retrieve a list of the content property types.
		/// </summary>
		/// <param name="pageSize">Used to create paged results from a query. Specifies the number of results to display on each page. Maximum: 200.</param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.PropertyTypeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetList( pageSize,  startIndex, authTicket);
		///   var propertyTypeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.PropertyTypeCollection> GetListClient(int? pageSize =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.PropertyTypeUrl.GetListUrl(pageSize, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.PropertyTypeCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieve the details of the content property type.
		/// </summary>
		/// <param name="propertyTypeName">The name of the content property type.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Content.PropertyType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=Get( propertyTypeName, authTicket);
		///   var propertyTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Content.PropertyType> GetClient(string propertyTypeName, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.PropertyTypeUrl.GetUrl(propertyTypeName);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Content.PropertyType>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// Retrieve the value types associated with a content property.
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Content.PropertyValueType"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=PropertyValueTypes(authTicket);
		///   var propertyValueTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Content.PropertyValueType>> PropertyValueTypesClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Content.PropertyTypeUrl.PropertyValueTypesUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Content.PropertyValueType>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

								
	}

}


