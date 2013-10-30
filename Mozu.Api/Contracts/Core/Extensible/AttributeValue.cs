using System;

namespace Mozu.Api.Contracts.Core.Extensible
{
	public class AttributeValue : Version
	{
		public string InternalValue { get; set; }
		public int? Sequence { get; set; }
		public AttributeValueLocalizedContent Content { get; set; }
	}

}