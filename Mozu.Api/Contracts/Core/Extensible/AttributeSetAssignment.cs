
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Mozu.Api.Contracts.Core.Extensible
{
		///
		///	Assign the attribute set to either customer or order.
		///
		public class AttributeSetAssignment
		{
			///
			///If true, the entity can be changed such as via text in a text box.
			///
			public bool IsEditable { get; set; }

			///
			///Identifier of the location. Locations describe where in the application the attribute definition will be rendered (such as a page).
			///
			public int LocationId { get; set; }

			///
			///The numeric value that denotes the place this entity occupies in the order of the entity list.
			///
			public int Sequence { get; set; }

			public int SiteGroupId { get; set; }

			public int? SiteId { get; set; }

			///
			///Wrapper for the collection of related attributes.
			///
			public AttributeSet AttributeSet { get; set; }

			///
			///Wrapper for the system-defined location identifier that denotes where entities will render. The location is where in the application, such as a web page, that the entities should show.
			///
			public Location Location { get; set; }

		}

}