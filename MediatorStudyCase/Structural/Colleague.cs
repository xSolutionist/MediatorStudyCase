using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorStudyCase.Structural
{
    public abstract class Colleague
    {
        protected Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            this._mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);


    }
}
