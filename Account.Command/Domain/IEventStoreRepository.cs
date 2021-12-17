using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Domain
{
    public interface IEventStoreRepository
    {
        EventModel Save(EventModel eventModel);
        List<EventModel> FindByAggregateId(string aggregateId);
    }
}
