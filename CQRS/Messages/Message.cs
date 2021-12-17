using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Messages
{
    public abstract class Message
    {
        private String _id;

        public void setId(String id)
        {
            this._id = id;
        }
        public String getId()
        {
            return this._id;
        }
    }
}
