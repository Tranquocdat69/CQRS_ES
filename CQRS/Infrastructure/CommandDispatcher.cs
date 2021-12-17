using CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Infrastructure
{
    public interface CommandDispatcher 
    {
        //void registerHandler<T> (string type, CommandHandlerMethod<T> handler) where T : BaseCommand; 
       /* void Send(BaseCommand command);
        void RegisterHandler<T>(T type, Action<T> handle) where T : BaseCommand;*/
    }
}
