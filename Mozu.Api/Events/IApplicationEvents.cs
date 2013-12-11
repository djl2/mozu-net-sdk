using Mozu.Api.Contracts.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mozu.Api.Events
{
    public interface IApplicationEvents
    {
        void Installed(ApiContext apiContext, Event eventPayLoad);
        void Uninstalled(ApiContext apiContext, Event eventPayLoad);
        void Enabled(ApiContext apiContext, Event eventPayLoad);
        void Disabled(ApiContext apiContext, Event eventPayLoad);
        void Upgraded(ApiContext apiContext, Event eventPayLoad);
    }
}