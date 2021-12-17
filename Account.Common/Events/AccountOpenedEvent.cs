using Account.Common.DTO;
using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Common.Events
{
    public class AccountOpenedEvent : BaseEvent
    {
        public AccountOpenedEvent()
        {
        }

        public AccountOpenedEvent(string accountHolder,AccountType accountType, DateTime createdDate, double openingBalance)
        {
            this.accountHolder = accountHolder;
            this.accountType = accountType;
            this.createdDate = createdDate;
            this.openingBalance = openingBalance;
        }

        public String accountHolder { get; set; }
        public AccountType accountType { get; set; }
        public DateTime createdDate { get; set; }
        public double openingBalance { get; set; }
    }
}
