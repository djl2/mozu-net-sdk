
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Carts
{
	public partial class ChangeMessageUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetMessages
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetMessagesUrl()
		{
			var url = "/api/commerce/carts/current/messages";
			return url;
		}

								/// <summary>
        /// Get Resource Url for RemoveAllMessages
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string RemoveAllMessagesUrl()
		{
			var url = "/api/commerce/carts/current/messages";
			return url;
		}

		/// <summary>
        /// Get Resource Url for RemoveMessage
        /// </summary>
        /// <param name="messageId">Identifier of the message to remove from the cart.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string RemoveMessageUrl(string messageId)
		{
			var url = "/api/commerce/carts/current/messages/{messageId}";
			FormatUrl( ref url, "messageId", messageId);
			return url;
		}

		
	}
}
