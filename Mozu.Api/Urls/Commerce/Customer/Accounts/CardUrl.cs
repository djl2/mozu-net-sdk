
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
	public partial class CardUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAccountCards
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountCardsUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAccountCard
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cardId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountCardUrl(int accountId, string cardId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards/{cardId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "cardId", cardId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddAccountCardUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="cardId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateAccountCardUrl(int accountId, string cardId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards/{cardId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "cardId", cardId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteAccountCard
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="cardId">Unique identifier of the credit card to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteAccountCardUrl(int accountId, string cardId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/cards/{cardId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "cardId", cardId);
			return mozuUrl;
		}

		
	}
}

