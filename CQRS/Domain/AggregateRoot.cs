using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain
{
    public abstract class AggregateRoot
    {
        protected String id;
        private int version = -1;

        private List<BaseEvent> changes = new List<BaseEvent>();

        public String getId()
        {
            return this.id;
        }

        public int getVersion()
        {
            return this.version;
        }

        public void setVersion(int version)
        {
            this.version = version;
        }

        public List<BaseEvent> getUncommittedChanges()
        {
            return this.changes;
        }

        public void markChangesAsCommitted()
        {
            this.changes.Clear();
        }

        protected virtual void When(BaseEvent @event) { }

        protected void applyChange(BaseEvent @event, Boolean isNewEvent)
        {
            When(@event);
            if (isNewEvent)
            {
                changes.Add(@event);
            }
        }

        public void raiseEvent(BaseEvent @event)
        {
            applyChange(@event, true);
        }

        public void replayEvents(List<BaseEvent> events)
        {
            events.ForEach(e => applyChange(e, false));
        }
    }
}
