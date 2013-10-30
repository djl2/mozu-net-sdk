
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Urls.Commerce.Customer.Accounts
{
	public partial class CardUrl : BaseUrl
	{

		/// <summary>
        /// Get Resource Url for GetAccountCards
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string GetAccountCardsUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards";
			FormatUrl( ref url, "accountId", accountId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for AddAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string AddAccountCardUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards";
			FormatUrl( ref url, "accountId", accountId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for UpdateAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string UpdateAccountCardUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards";
			FormatUrl( ref url, "accountId", accountId);
			return url;
		}

				/// <summary>
        /// Get Resource Url for DeleteAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="cardId">Unique identifier of the credit card to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static string DeleteAccountCardUrl(int accountId, string cardId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards/{cardId}";
			FormatUrl( ref url, "accountId", accountId);
			FormatUrl( ref url, "cardId", cardId);
			return url;
		}

		
	}
}

