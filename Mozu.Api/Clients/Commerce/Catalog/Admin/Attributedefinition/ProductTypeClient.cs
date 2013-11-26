
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


namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ProductTypeClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductTypes(dataViewMode);
		///   var productTypeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection> GetProductTypesClient(DataViewMode dataViewMode)
		{
			return GetProductTypesClient(dataViewMode,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductTypes(dataViewMode,  filter,  pageSize,  sortBy,  startIndex, authTicket);
		///   var productTypeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection> GetProductTypesClient(DataViewMode dataViewMode, string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.ProductTypeUrl.GetProductTypesUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productTypeId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductType(dataViewMode,  productTypeId, authTicket);
		///   var productTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> GetProductTypeClient(DataViewMode dataViewMode, int productTypeId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.ProductTypeUrl.GetProductTypeUrl(productTypeId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType>().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productType"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddProductType(dataViewMode,  productType, authTicket);
		///   var productTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> AddProductTypeClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductType productType, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.ProductTypeUrl.AddProductTypeUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ProductAdmin.ProductType>(productType).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="productTypeId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productType"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductType(dataViewMode,  productType,  productTypeId, authTicket);
		///   var productTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> UpdateProductTypeClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductType productType, int productTypeId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.ProductTypeUrl.UpdateProductTypeUrl(productTypeId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.ProductAdmin.ProductType>(productType).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="productTypeId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProductType(dataViewMode,  productTypeId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteProductTypeClient(DataViewMode dataViewMode, int productTypeId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.ProductTypeUrl.DeleteProductTypeUrl(productTypeId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url).WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString());
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


