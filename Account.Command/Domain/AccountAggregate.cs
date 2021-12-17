using Account.Command.Commands;
using Account.Common.Events;
using CQRS.Domain;
using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Domain
{
    public class AccountAggregate : AggregateRoot
    {
        private Boolean _active;
        private double _balance;

        public double getBalance()
        {
            return this._balance;
        }
        public AccountAggregate()
        {

        }
        public AccountAggregate(OpenAccountCommand command)
        {
            AccountOpenedEvent accountOpenedEvent = new AccountOpenedEvent();
            accountOpenedEvent.setId(command.getId());
            accountOpenedEvent.accountHolder = command.accountHolder;
            accountOpenedEvent.accountType = command.accountType;
            accountOpenedEvent.createdDate = DateTime.Now;
            accountOpenedEvent.openingBalance = command.openingBalance;
            raiseEvent(accountOpenedEvent);
        }

        protected override void When(BaseEvent @event) {
            switch (@event)
            {
                case AccountOpenedEvent ev: apply(ev);
                break;
            }
        }

        public void apply(AccountOpenedEvent @event)
        {
            this.id = @event.getId();
            this._active = true;
            this._balance = @event.openingBalance;
        }

    }
}
