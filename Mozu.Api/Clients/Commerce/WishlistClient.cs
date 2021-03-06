
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


namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// Use the Wish Lists resource to manage the shopper wish lists of products associated with a customer account. Although customer accounts are managed at the tenant level, the system stores shopper wish lists at the site level. This enables the same customer to have wish lists for each of a merchant's sites. Use the Wish List Items resource to manage items in a wish list.
	/// </summary>
	public partial class WishlistClient 	{
		
		/// <summary>
		/// Retrieves a list of shopper wish lists according to any filter and sort criteria.
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
			return GetWishlistsClient( null,  null,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of shopper wish lists according to any filter and sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="q">A list of search terms to use in the query when searching across wish list name. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlists( startIndex,  pageSize,  sortBy,  filter,  q,  qLimit);
		///   var wishlistCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection> GetWishlistsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.GetWishlistsUrl(filter, pageSize, q, qLimit, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.WishlistCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the shopper wish list specified in the request.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the shopper wish list to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlist( wishlistId);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> GetWishlistClient(string wishlistId)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.GetWishlistUrl(wishlistId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customerAccountId"></param>
		/// <param name="wishlistName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetWishlistByName( customerAccountId,  wishlistName);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> GetWishlistByNameClient(int customerAccountId, string wishlistName)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.GetWishlistByNameUrl(customerAccountId, wishlistName);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new shopper wish list for the associated customer account. Although customer accounts are maintained at the tenant level, the system stores wish lists at the site level. Newly created wish lists do not have any items.
		/// </summary>
		/// <param name="wishlist">Properties of the wish list to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateWishlist( wishlist);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> CreateWishlistClient(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.CreateWishlistUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>(wishlist);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more properties of a shopper wish list defined for a customer account.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the shopper wish list to update.</param>
		/// <param name="wishlist">Properties of the shopper wish list to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateWishlist( wishlist,  wishlistId);
		///   var wishlistClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist> UpdateWishlistClient(Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist wishlist, string wishlistId)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.UpdateWishlistUrl(wishlistId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Wishlists.Wishlist>(wishlist);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the shopper wish list specified in the request and all items associated with it.
		/// </summary>
		/// <param name="wishlistId">Unique identifier of the wish list to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteWishlist( wishlistId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteWishlistClient(string wishlistId)
		{
			var url = Mozu.Api.Urls.Commerce.WishlistUrl.DeleteWishlistUrl(wishlistId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


