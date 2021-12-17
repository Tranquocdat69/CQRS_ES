using CQRS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Handlers
{
    public interface EventSourcingHandler <T>
    {
        void Save(AggregateRoot aggregate);
        T GetById(string id);
    }
}
