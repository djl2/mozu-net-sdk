
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

namespace Mozu.Api.Urls.Commerce.Customer.Accounts
{
	public partial class TransactionUrl 
	{

		/// <summary>
        /// Get Resource Url for GetTransactions
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account for which to retrieve transactions.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTransactionsUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/transactions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddTransaction
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddTransactionUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/transactions";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

						/// <summary>
        /// Get Resource Url for RemoveTransaction
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account from which to delete the transaction.</param>
        /// <param name="transactionId">Unique identifier of the transaction to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveTransactionUrl(int accountId, string transactionId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/transactions/{transactionId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "transactionId", transactionId);
			return mozuUrl;
		}

		
	}
}

