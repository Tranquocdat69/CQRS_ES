using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Commands
{
    public interface CommandHandler
    {
        void handle(OpenAccountCommand command);
        void handle(DepositFundsCommand command);
        void handle(WithdrawFundsCommand command);
        void handle(CloseAccountCommand command);
    }
}
