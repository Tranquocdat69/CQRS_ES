using CQRS;
using CQRS.Commands;
using CQRS.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Command.Infrastructure
{
    public class AccountCommandDispatcher : CommandDispatcher
    {
        /*private static Dictionary<BaseCommand, Delegate> routes = new Dictionary<BaseCommand, Delegate>();

        public void RegisterHandler<T>(T type, Action<T> handle) where T : BaseCommand
        {
            if (!routes.ContainsKey(type))
            {
                routes.Add(type, handle);
            }
        }

        public void Send(BaseCommand command)
        {
            var handler = routes[command];
            handler.Method.Invoke(null, command);
        }*/
    }
}
