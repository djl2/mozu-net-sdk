
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.Content
{
		///
		///	A high level description of the document draft.
		///
		public class DocumentDraftSummary
		{
			public DateTime? ActiveUpdateDate { get; set; }

			///
			///Name of the document list associated with the draft.
			///
			public string DocumentListName { get; set; }

			public DateTime DraftUpdateDate { get; set; }

			///
			///Identifier of document draft.
			///
			public string Id { get; set; }

			///
			///Name of the document draft.
			///
			public string Name { get; set; }

			///
			///Whether the draft has been published.
			///
			public string PublishType { get; set; }

			///
			///Unique identifier of the user who last modified the item. This value is system-supplied and read-only.
			///
			public string UpdatedBy { get; set; }

		}

}