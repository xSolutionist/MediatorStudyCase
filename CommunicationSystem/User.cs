using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSystem
{
    public class User : TeamMember
    {
        public User(string name) : base(name)
        {

        }

        public override void Recieve(string from, string message)
        {
            Console.Write($"{this.name} ({nameof(User)}) has recieved: ");
            base.Recieve(from, message);
        }
    }
}
