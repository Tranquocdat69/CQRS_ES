using Account.Command.Domain;
using CQRS.Events;
using CQRS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Account.Command.Infrastructure
{
    public class AccountEventStore : EventStore
    {
        private IEventStoreRepository _eventStoreRepository;

        public AccountEventStore(IEventStoreRepository eventStoreRepository)
        {
            this._eventStoreRepository = eventStoreRepository;
        }

        public List<BaseEvent> GetEvents(string aggregateId)
        {
            var eventStream = _eventStoreRepository.FindByAggregateId(aggregateId);
            List<BaseEvent> baseEvents = eventStream.Select(x => x.eventData).ToList();
            return baseEvents;
        }

        public void SaveEvents(string aggregateId, List<BaseEvent> events, int expectedVersion)
        {
            var eventStream = _eventStoreRepository.FindByAggregateId(aggregateId);
            if (expectedVersion != -1 && eventStream[eventStream.Count - 1].version != expectedVersion)
            {
                throw new Exception("Ko the thao tac cung mot luc");
            }

            var version = expectedVersion;
            foreach (var e in events)
            {
                version++;
                e.setVersion(version);
                var eventModel = new EventModel(Guid.NewGuid().ToString(), DateTime.Now, aggregateId, Assembly.GetAssembly(typeof(AccountAggregate)).ToString(), version, e.GetType().ToString(),e);
                var persistedEvent = _eventStoreRepository.Save(eventModel);
                if (!String.IsNullOrEmpty(persistedEvent.id))
                {
                    //produce to kafka
                }
            }
        }
    }
}
