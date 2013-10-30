using Mozu.Api.Contracts.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Mozu.Api.Events
{
	public interface IProductEvents
	{
		void Created(ApiContext apiContext, Event eventPayLoad);
		void Updated(ApiContext apiContext, Event eventPayLoad);
		void Deleted(ApiContext apiContext, Event eventPayLoad);
	}
}
