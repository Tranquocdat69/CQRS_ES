using Account.Common.DTO;
using CQRS.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Commands
{
    public class OpenAccountCommand : BaseCommand, IRequest<string>
    {
        public OpenAccountCommand()
        {

        }
        public OpenAccountCommand(string accountHolder,AccountType accountType, double openingBalance)
        {
            this.accountHolder = accountHolder;
            this.accountType = accountType;
            this.openingBalance = openingBalance;
        }

        public String accountHolder { get; set; }
        public AccountType accountType { get; set; }
        public double openingBalance { get; set; }
    }
}
