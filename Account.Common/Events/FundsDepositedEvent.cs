using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Common.Events
{
    public class FundsDepositedEvent : BaseEvent
    {
        public double amount { get; set; }
    }
}
