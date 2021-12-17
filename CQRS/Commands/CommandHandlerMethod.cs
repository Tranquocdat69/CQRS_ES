using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands
{
    public interface CommandHandlerMethod<T>
    {
        Action<T> handle(T command);
    }
}
