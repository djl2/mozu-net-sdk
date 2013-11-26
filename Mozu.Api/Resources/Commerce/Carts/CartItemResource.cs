
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


namespace Mozu.Api.Resources.Commerce.Carts
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CartItemResource  	{
				///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;
		public CartItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItemCollection = cartitem.GetCartItems(authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection GetCartItems(AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemsClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.GetCartItem( cartItemId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem GetCartItem(string cartItemId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemClient( cartItemId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="cartItem"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.AddItemToCart( cartItem, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem AddItemToCart(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.AddItemToCartClient( cartItem, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="cartItem"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.UpdateCartItem( cartItem,  cartItemId, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem UpdateCartItem(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string cartItemId, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemClient( cartItem,  cartItemId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId"></param>
		/// <param name="quantity"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.UpdateCartItemQuantity( cartItemId,  quantity, authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem UpdateCartItemQuantity(string cartItemId, int quantity, AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemQuantityClient( cartItemId,  quantity, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cart = cartitem.RemoveAllCartItems(authTicket);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart RemoveAllCartItems(AuthTicket authTicket= null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.RemoveAllCartItemsClient(authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartItemId"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   cartitem.DeleteCartItem( cartItemId, authTicket);
		/// </code>
		/// </example>
		public virtual void DeleteCartItem(string cartItemId, AuthTicket authTicket= null)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.DeleteCartItemClient( cartItemId, authTicket);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		
	}

}


