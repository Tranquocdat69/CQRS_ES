using CQRS.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Events
{
    public abstract class BaseEvent : Message
    {
        private int _version;
        public void setVersion(int version)
        {
            this._version = version;
        }
        public int getVersion()
        {
            return this._version;
        }
    }
}
