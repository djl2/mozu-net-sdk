
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
	/// Collection of the attributes that are properties in this product type.
	/// </summary>
	public partial class ProductTypePropertyResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public ProductTypePropertyResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of product properties that belong to a product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type whose properties are being retrieved as a paged list.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.GetProperties(dataViewMode,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> GetProperties(DataViewMode dataViewMode, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertiesClient(dataViewMode,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the single property by providing the property ID and the attribute's user-defined fully qualified name.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="productTypeId">Identifier of the product type whose single instance of a property is being retrieved.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.GetProperty(dataViewMode,  attributeFQN,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType GetProperty(DataViewMode dataViewMode, string attributeFQN, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.GetPropertyClient(dataViewMode,  attributeFQN,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Adds or creates the attribute which exists as properties in the product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type whose properties are being added or created to the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="attributeInProductType">The attribute in product type refers to the specific product attribute that is being created to exist as a property only available in the product type template.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.AddProperty(dataViewMode,  attributeInProductType,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType AddProperty(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.AddPropertyClient(dataViewMode,  attributeInProductType,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Updates the single property by providing the property ID and the attribute's user-defined fully qualified name.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="productTypeId">Identifier of the product type whose single instance of a property is being updated.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="attributeInProductType">The properties of the attribute (that exist as properties) are being updated.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.AttributeInProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   var attributeInProductType = producttypeproperty.UpdateProperty(dataViewMode,  attributeInProductType,  attributeFQN,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.AttributeInProductType UpdateProperty(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.AttributeInProductType attributeInProductType, string attributeFQN, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeInProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.UpdatePropertyClient(dataViewMode,  attributeInProductType,  attributeFQN,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Deletes the property by providing the attribute's user-defined fully qualified name.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="productTypeId">Identifier of the product type whose properties are being deleted.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var producttypeproperty = new ProductTypeProperty();
		///   producttypeproperty.DeleteProperty(dataViewMode,  attributeFQN,  productTypeId, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteProperty(DataViewMode dataViewMode, string attributeFQN, int productTypeId, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Producttypes.ProductTypePropertyClient.DeletePropertyClient(dataViewMode,  attributeFQN,  productTypeId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


