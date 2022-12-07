using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CommandPoc.Core.Messages
{
    public abstract class Command : IRequest<bool>
    {
        public DateTime Timestamp { get; private set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}