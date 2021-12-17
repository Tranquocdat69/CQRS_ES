using Account.Command.Data;
using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Domain
{
    public class EventStoreRepository : IEventStoreRepository
    {
        ApplicationDBContext _dbContext;
        public EventStoreRepository(ApplicationDBContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public List<EventModel> FindByAggregateId(string aggregateId)
        {
            List<EventModel> eventModels = _dbContext.EventModels.Where(e => e.aggregationId == aggregateId).ToList();
            return eventModels;
        }

        public EventModel Save(EventModel eventModel)
        {
            _dbContext.EventModels.Add(eventModel);
            int check = _dbContext.SaveChanges();
            if (check > 0)
            {
                return eventModel;
            }
            return null;
        }
    }
}
