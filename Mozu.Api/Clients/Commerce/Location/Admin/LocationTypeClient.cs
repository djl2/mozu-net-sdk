
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


namespace Mozu.Api.Clients.Commerce.Location.Admin
{
	/// <summary>
	/// 
	/// </summary>
	public partial class LocationTypeClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Location.LocationType"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationTypes(authTicket);
		///   var locationTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Location.LocationType>> GetLocationTypesClient(AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Location.Admin.LocationTypeUrl.GetLocationTypesUrl();
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Location.LocationType>>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="locationTypeCode"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationType( locationTypeCode, authTicket);
		///   var locationTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationType> GetLocationTypeClient(string locationTypeCode, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Location.Admin.LocationTypeUrl.GetLocationTypeUrl(locationTypeCode);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationType>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="locationType"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLocationType( locationType, authTicket);
		///   var locationTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationType> AddLocationTypeClient(Mozu.Api.Contracts.Location.LocationType locationType, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Location.Admin.LocationTypeUrl.AddLocationTypeUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationType>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Location.LocationType>(locationType);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="locationTypeCode"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="locationType"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationType"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateLocationType( locationType,  locationTypeCode, authTicket);
		///   var locationTypeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationType> UpdateLocationTypeClient(Mozu.Api.Contracts.Location.LocationType locationType, string locationTypeCode, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Location.Admin.LocationTypeUrl.UpdateLocationTypeUrl(locationTypeCode);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationType>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.Location.LocationType>(locationType);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="locationTypeCode"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteLocationType( locationTypeCode, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteLocationTypeClient(string locationTypeCode, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.Location.Admin.LocationTypeUrl.DeleteLocationTypeUrl(locationTypeCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}

