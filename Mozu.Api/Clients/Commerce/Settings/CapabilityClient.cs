using System;
using System.Collections.Generic;

namespace Mozu.Api.Clients.Commerce.Settings
{
	/// <summary>
	/// 
	/// </summary>
	public partial class CapabilityClient 	{
		
		/// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>
        ///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Core.ThirdParty.Capability"/>}}
        /// </returns>
        /// <example>
        /// <code>
        ///   var mozuClient=GetCapabilities( filter);
        ///   var capabilityClient = mozuClient.WithBaseAddress(url).Execute().Result();
        /// </code>
        /// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Core.ThirdParty.Capability>> GetCapabilitiesClient(string filter)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.CapabilityUrl.GetCapabilitiesUrl(filter);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Core.ThirdParty.Capability>>().WithVerb(verb).WithResourceUrl(url);
        return mozuClient;

		}

								
	}

}


