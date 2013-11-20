
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

			public bool? EnablePublishing { get; set; }

			///
			///The name of the document list.
			///
			public string Name { get; set; }

			public bool? SupportsPublishing { get; set; }

		}

}