using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSystem
{
    public class Tester:TeamMember
    {
        public Tester(string name) : base(name)
        {

        }

        public override void Recieve(string from, string message)
        {
            Console.WriteLine($"{this.name} ({nameof(User)}) has recieved: ");
            base.Recieve(from, message);
        }
    }
}
