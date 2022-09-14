using MicroservicesEventBusPractice.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicesEventBusPractice.EventBus.Interfaces
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
    where TIntegrationEvent : IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
