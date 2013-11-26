
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


namespace Mozu.Api.Resources.Platform
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ReferenceDataResource  	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.AddressSchema"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var addressSchema = referencedata.GetAddressSchema();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.AddressSchema GetAddressSchema()
		{
			return GetAddressSchema( null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countryCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.AddressSchema"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var addressSchema = referencedata.GetAddressSchema( countryCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.AddressSchema GetAddressSchema(string countryCode =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.AddressSchema> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetAddressSchemaClient( countryCode);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.AddressSchemaCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var addressSchemaCollection = referencedata.GetAddressSchemas();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.AddressSchemaCollection GetAddressSchemas()
		{
			MozuClient<Mozu.Api.Contracts.Reference.AddressSchemaCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetAddressSchemasClient();
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="behaviorId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.Behavior"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behavior = referencedata.GetBehavior( behaviorId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.Behavior GetBehavior(int behaviorId)
		{
			MozuClient<Mozu.Api.Contracts.Core.Behavior> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorClient( behaviorId);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCategoryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCategoryCollection = referencedata.GetBehaviorCategories();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.BehaviorCategoryCollection GetBehaviorCategories()
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCategoryCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorCategoriesClient();
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="categoryId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCategory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCategory = referencedata.GetBehaviorCategory( categoryId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.BehaviorCategory GetBehaviorCategory(int categoryId)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCategory> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorCategoryClient( categoryId);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCollection = referencedata.GetBehaviors();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.BehaviorCollection GetBehaviors()
		{
			return GetBehaviors( null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userType"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Core.BehaviorCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var behaviorCollection = referencedata.GetBehaviors( userType);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Core.BehaviorCollection GetBehaviors(string userType =  null)
		{
			MozuClient<Mozu.Api.Contracts.Core.BehaviorCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetBehaviorsClient( userType);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.ContentLocaleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var contentLocaleCollection = referencedata.GetContentLocales();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.ContentLocaleCollection GetContentLocales()
		{
			MozuClient<Mozu.Api.Contracts.Reference.ContentLocaleCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetContentLocalesClient();
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CountryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var countryCollection = referencedata.GetCountries();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.CountryCollection GetCountries()
		{
			MozuClient<Mozu.Api.Contracts.Reference.CountryCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCountriesClient();
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.CurrencyCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var currencyCollection = referencedata.GetCurrencies();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.CurrencyCollection GetCurrencies()
		{
			MozuClient<Mozu.Api.Contracts.Reference.CurrencyCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetCurrenciesClient();
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.TimeZoneCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var timeZoneCollection = referencedata.GetTimeZones();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.TimeZoneCollection GetTimeZones()
		{
			MozuClient<Mozu.Api.Contracts.Reference.TimeZoneCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetTimeZonesClient();
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.TopLevelDomainCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var topLevelDomainCollection = referencedata.GetTopLevelDomains();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.TopLevelDomainCollection GetTopLevelDomains()
		{
			MozuClient<Mozu.Api.Contracts.Reference.TopLevelDomainCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetTopLevelDomainsClient();
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.UnitOfMeasureCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var unitOfMeasureCollection = referencedata.GetUnitsOfMeasure();
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.UnitOfMeasureCollection GetUnitsOfMeasure()
		{
			return GetUnitsOfMeasure( null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Reference.UnitOfMeasureCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var referencedata = new ReferenceData();
		///   var unitOfMeasureCollection = referencedata.GetUnitsOfMeasure( filter);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Reference.UnitOfMeasureCollection GetUnitsOfMeasure(string filter =  null)
		{
			MozuClient<Mozu.Api.Contracts.Reference.UnitOfMeasureCollection> response;
			var client = Mozu.Api.Clients.Platform.ReferenceDataClient.GetUnitsOfMeasureClient( filter);
			response= client.Execute();
			return response.Result();

		}

								
	}

}


