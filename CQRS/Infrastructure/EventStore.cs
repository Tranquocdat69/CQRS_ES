using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure
{
    public interface EventStore
    {
        void SaveEvents(string aggregateId, List<BaseEvent> events, int expectedVersion);
        List<BaseEvent> GetEvents(string aggregateId);
    }
}
