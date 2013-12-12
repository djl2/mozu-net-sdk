
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

namespace Mozu.Api.Contracts.Content
{
		///
		///	The list of document types and related properties that define content used by the content management system (CMS).
		///
		public class DocumentList
		{
			///
			///A document type is a template.
			///
			public List<string> DocumentTypes { get; set; }

			///
			///If true, publishing of draft documents in this document list is enabled for the site. If false, all document changes are immediately published in live mode.
			///
			public bool? EnablePublishing { get; set; }

			///
			///The name of the document list.
			///
			public string Name { get; set; }

			///
			///If true, changes documents in this list can be saved as drafts until they are published to the site. If false, all document changes are immediately published in live mode. System-supplied and read only.
			///
			public bool? SupportsPublishing { get; set; }

		}

}