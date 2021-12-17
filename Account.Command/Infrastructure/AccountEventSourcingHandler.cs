using Account.Command.Domain;
using CQRS.Domain;
using CQRS.Events;
using CQRS.Handlers;
using CQRS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Infrastructure
{
    public class AccountEventSourcingHandler : EventSourcingHandler<AccountAggregate>
    {
        private EventStore _eventStore;
        public AccountEventSourcingHandler(EventStore eventStore)
        {
            this._eventStore = eventStore;
        }
        public AccountAggregate GetById(string id)
        {
            AccountAggregate aggregate = new AccountAggregate();
            List<BaseEvent> events = _eventStore.GetEvents(id);
            if (events !=null && events.Count != 0)
            {
                aggregate.replayEvents(events);
                int latestVersion = events[events.Count - 1].getVersion();
                aggregate.setVersion(latestVersion);
            }
            return aggregate;

        }

        public void Save(AggregateRoot aggregate)
        {
            _eventStore.SaveEvents(aggregate.getId(), aggregate.getUncommittedChanges(), aggregate.getVersion());
            aggregate.markChangesAsCommitted();
        }
    }
}
