using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mozu.Api.Contracts.Event;

namespace Mozu.Api.Events
{
    public interface ICustomerAccount
    {
        void Created(ApiContext apiContext, Event mzEvent);
        void Updated(ApiContext apiContext, Event mzEvent);
        void Deleted(ApiContext apiContext, Event mzEvent);
    }
}
