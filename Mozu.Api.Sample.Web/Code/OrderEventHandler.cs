using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mozu.Api.Contracts.Event;
using Mozu.Api.Events;

namespace Mozu.Api.Sample.Web.Code
{
    public class OrderEventHandler : IOrderEvents
    {
        public void Opened(ApiContext apiContext, Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Closed(ApiContext apiContext, Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Cancelled(ApiContext apiContext, Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Shipped(ApiContext apiContext, Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void Updated(ApiContext apiContext, Event eventPayLoad)
        {
            throw new NotImplementedException();
        }

        public void All(ApiContext apiContext, Event eventPayLoad)
        {
            throw new NotImplementedException();
        }
    }
}