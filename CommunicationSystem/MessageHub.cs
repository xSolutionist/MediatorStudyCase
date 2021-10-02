using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSystem
{
    public abstract class MessageHub
    {
        public abstract void RegisterSingle(TeamMember member);
        public abstract void Send(string from, string message);

    }
}
