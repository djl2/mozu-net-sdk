
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.Core
{
		///
		///	Identifier and datetime stamp information recorded when creating or updating a resource entity. This value is system-supplied and read-only.
		///
		public class AuditInfo
		{
			///
			///Unique identifier of the user created the resource entity. This value is system-supplied and read-only.
			///
			public string CreateBy { get; set; }

			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime? CreateDate { get; set; }

			///
			///Unique identifier of the user who last modified the item. This value is system-supplied and read-only.
			///
			public string UpdateBy { get; set; }

			///
			///Date and time when the entity was last updated, represented in UTC Date/Time.
			///
			public DateTime? UpdateDate { get; set; }

		}

}