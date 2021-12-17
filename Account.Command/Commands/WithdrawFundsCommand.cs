using CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Commands
{
    public class WithdrawFundsCommand : BaseCommand
    {
        private double amount;
    }
}
