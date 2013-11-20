
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


namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Products
{
	/// <summary>
	/// Query, create, and update product properties.
	/// </summary>
	public partial class ProductPropertyResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public ProductPropertyResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves a list of product properties by providing the product code.
		/// </summary>
		/// <param name="productCode">Identifies the product for which a list of properties is being retrieved.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.GetProperties(dataViewMode,  productCode, authTicket);
		/// </code>
		/// </example>
		public virtual List<Mozu.Api.Contracts.ProductAdmin.ProductProperty> GetProperties(DataViewMode dataViewMode, string productCode, AuthTicket authTicket= null)
		{
			MozuClient<List<Mozu.Api.Contracts.ProductAdmin.ProductProperty>> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertiesClient(dataViewMode,  productCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the individual product property by providing the product code and the attribute's fully qualified name.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="productCode">Identifies the product for which a single property is being retrieved.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.GetProperty(dataViewMode,  attributeFQN,  productCode, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductProperty GetProperty(DataViewMode dataViewMode, string attributeFQN, string productCode, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.GetPropertyClient(dataViewMode,  attributeFQN,  productCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Adds or creates an individual property by providing the product code.
		/// </summary>
		/// <param name="productCode">The merchant-created code that uniquely identifies the product such as a SKU or item number. Identifies the product for which a new property is created.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productProperty">The details of the product property including the attribute detail, user's fully qualified name, and the list of product property values to add.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.AddProperty(dataViewMode,  productProperty,  productCode, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductProperty AddProperty(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string productCode, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.AddPropertyClient(dataViewMode,  productProperty,  productCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Update the details of a product property by providng the product code and the attribute's fully qualified name.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="productCode">Identifies the product for which a list of properties is being updated.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="productProperty">The details of the product property including the attribute detail, user's fully qualified name, and the list of product property values to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductProperty"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   var productProperty = productproperty.UpdateProperty(dataViewMode,  productProperty,  attributeFQN,  productCode, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductProperty UpdateProperty(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductProperty productProperty, string attributeFQN, string productCode, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductProperty> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.UpdatePropertyClient(dataViewMode,  productProperty,  attributeFQN,  productCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// Deletes the property by providing the product code and the attribute's fully qualified name.
		/// </summary>
		/// <param name="attributeFQN">"The fully qualified name of the attribute, which is a user defined attribute identifier."</param>
		/// <param name="productCode">Identifies the product for which a new property is being deleted.</param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var productproperty = new ProductProperty();
		///   productproperty.DeleteProperty(dataViewMode,  attributeFQN,  productCode, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteProperty(DataViewMode dataViewMode, string attributeFQN, string productCode, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Products.ProductPropertyClient.DeletePropertyClient(dataViewMode,  attributeFQN,  productCode, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


