
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
	public partial class TransactionUrl : MozuUrl
	{

		/// <summary>
        /// Get Resource Url for GetTransactions
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetTransactionsUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/transactions";
			FormatUrl( ref url, "accountId", accountId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

				/// <summary>
        /// Get Resource Url for AddTransaction
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddTransactionUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/transactions";
			FormatUrl( ref url, "accountId", accountId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

						/// <summary>
        /// Get Resource Url for RemoveTransaction
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveTransactionUrl(int accountId, string transactionId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/transactions/{transactionId}";
			FormatUrl( ref url, "accountId", accountId);
			FormatUrl( ref url, "transactionId", transactionId);
			return new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD) ;
		}

		
	}
}

