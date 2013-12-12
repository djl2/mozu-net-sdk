using Mozu.Api.Contracts.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mozu.Api.Events
{
    public interface IReturnEvents
    {
        void Opened(ApiContext apiContext, Event eventPayLoad);
        void Closed(ApiContext apiContext, Event eventPayLoad);
        void Cancelled(ApiContext apiContext, Event eventPayLoad);
        void Updated(ApiContext apiContext, Event eventPayLoad);
    }
}