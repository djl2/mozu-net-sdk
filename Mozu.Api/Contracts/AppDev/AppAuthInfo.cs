
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.AppDev
{
		///
		///	The information required to authenticate third party applications against the Mozu API.
		///
		public class AppAuthInfo
		{
			///
			///Unique identifier of the application. System-supplied and read-only.
			///
			public string ApplicationId { get; set; }

			///
			///System-supplied alphanumeric code used to authenticate applications. This string is only available for viewing in Mozu Dev Center.
			///
			public string SharedSecret { get; set; }

		}

}