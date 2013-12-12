using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mozu.Api.Contracts.Event;

namespace Mozu.Api.Events
{
    public interface IDiscountEvents
    {
        void Created(ApiContext apiContext, Event eventPayLoad);
        void Updated(ApiContext apiContext, Event eventPayLoad);
        void Deleted(ApiContext apiContext, Event eventPayLoad);
    }
}
