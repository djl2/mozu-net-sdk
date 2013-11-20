
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
	public partial class ChannelGroupClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetChannelGroups();
		///   var channelGroupCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection> GetChannelGroupsClient()
		{
			return GetChannelGroupsClient( null,  null,  null,  null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetChannelGroups( filter,  pageSize,  sortBy,  startIndex, authTicket);
		///   var channelGroupCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection> GetChannelGroupsClient(string filter =  null, int? pageSize =  null, string sortBy =  null, int? startIndex =  null, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ChannelGroupUrl.GetChannelGroupsUrl(filter, pageSize, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetChannelGroup( code, authTicket);
		///   var channelGroupClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> GetChannelGroupClient(string code, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ChannelGroupUrl.GetChannelGroupUrl(code);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup>().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="channelGroup"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateChannelGroup( channelGroup, authTicket);
		///   var channelGroupClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> CreateChannelGroupClient(Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup channelGroup, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ChannelGroupUrl.CreateChannelGroupUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup>(channelGroup);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <param name="channelGroup"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateChannelGroup( channelGroup,  code, authTicket);
		///   var channelGroupClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> UpdateChannelGroupClient(Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup channelGroup, string code, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ChannelGroupUrl.UpdateChannelGroupUrl(code);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup>().WithVerb(verb).WithResourceUrl(url).WithBody<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup>(channelGroup);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

				/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="authTicket">User Auth Ticket{<see cref="Mozu.Api.Security.AuthTicket"/>}. If User Token is expired, authTicket will have a new Token and expiration date.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteChannelGroup( code, authTicket);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteChannelGroupClient(string code, AuthTicket authTicket= null)
		{
			var url = Mozu.Api.Urls.Commerce.ChannelGroupUrl.DeleteChannelGroupUrl(code);
			const string verb = "DELETE";
			var mozuClient = new MozuClient().WithVerb(verb).WithResourceUrl(url);
			if (authTicket != null)
				mozuClient = mozuClient.WithUserAuth(authTicket);
			return mozuClient;

		}

		
	}

}


