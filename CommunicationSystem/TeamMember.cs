using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSystem
{
    public abstract class TeamMember
    {

        public readonly string _name;
        private MessageHub _messageHub;

        public TeamMember(string name)
        {
            _name = name;
        }

        internal void InitializeMessageHub(MessageHub hub)
        {
            _messageHub = hub;
        }

        public void Send(string message)
        {
            _messageHub.Send(_name, message);
        }

        public virtual void Recieve(string from, string message)
        {
            Console.WriteLine($"From {from}: '{message}");
        }


    }
}
