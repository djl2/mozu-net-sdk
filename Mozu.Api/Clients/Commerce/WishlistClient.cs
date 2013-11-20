
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


namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// 
	/// </summary>
	public partial class WishlistClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlists();
		///   var wishlistCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection> GetWishlistsClient()
		{
			return GetWishlistsClient( null,  null,  null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="q"></param>
		/// <param name="qLimit"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlists( filter,  pageSize,  q,  qLimit,  sortBy,  startIndex, authTicket);
		///   var wishlistCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection> GetWishlistsClient(string filter =  null, int? pageSize =  null, string q =  null, int? qLimit =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.GetWishlistsUrl(filter, pageSize, q, qLimit, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="wishlistId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlist( wishlistId, authTicket);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> GetWishlistClient(string wishlistId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.GetWishlistUrl(wishlistId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="wishlist"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateWishlist( wishlist, authTicket);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> CreateWishlistClient(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.CreateWishlistUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>(wishlist);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="wishlistId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="wishlist"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateWishlist( wishlist,  wishlistId, authTicket);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> UpdateWishlistClient(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist, string wishlistId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.UpdateWishlistUrl(wishlistId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>(wishlist);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="wishlistId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteWishlist( wishlistId, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteWishlistClient(string wishlistId, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.DeleteWishlistUrl(wishlistId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


