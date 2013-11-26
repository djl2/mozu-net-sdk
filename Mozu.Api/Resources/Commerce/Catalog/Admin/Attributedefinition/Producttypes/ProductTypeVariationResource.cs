
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition.Producttypes
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ProductTypeVariationResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public ProductTypeVariationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
				/// <summary>
		/// 
		/// </summary>
		/// <param name="productTypeId"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productOptionsIn"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypevariation = new ProductTypeVariation();
		///   var productVariationPagedCollection = producttypevariation.GenerateProductVariations(dataViewMode,  productOptionsIn,  productTypeId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection GenerateProductVariations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductOption> productOptionsIn, int productTypeId)
		{
			return GenerateProductVariations(dataViewMode,  productOptionsIn,  productTypeId,  null,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="productCode"></param>
		/// <param name="productTypeId"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productOptionsIn"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypevariation = new ProductTypeVariation();
		///   var productVariationPagedCollection = producttypevariation.GenerateProductVariations(dataViewMode,  productOptionsIn,  productTypeId,  filter,  pageSize,  productCode,  sortBy,  startIndex, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection GenerateProductVariations(DataViewMode dataViewMode, List<Mozu.Api.Contracts.ProductAdmin.ProductOption> productOptionsIn, int productTypeId, string filter =  null, int? pageSize =  null, string productCode =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductVariationPagedCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypeVariationClient.GenerateProductVariationsClient(dataViewMode,  productOptionsIn,  productTypeId,  filter,  pageSize,  productCode,  sortBy,  startIndex, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

						
	}

}


