using Account.Command.Domain;
using CQRS.Handlers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Account.Command.Commands
{
    public class OpenAccountCommandHandler : IRequestHandler<OpenAccountCommand,string>
    {
        private EventSourcingHandler<AccountAggregate> _eventSourcingHandler;

        public OpenAccountCommandHandler()
        {
        }

        public OpenAccountCommandHandler(EventSourcingHandler<AccountAggregate> eventSourcingHandler)
        {
            this._eventSourcingHandler = eventSourcingHandler;
        }

        public Task<string> Handle(OpenAccountCommand command, CancellationToken cancellationToken)
        {
            var aggregate = new AccountAggregate(command);
            _eventSourcingHandler.Save(aggregate);
            return Task.FromResult("oke");
        }
    }
}
