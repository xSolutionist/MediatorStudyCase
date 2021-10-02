using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSystem
{
    public class Administrator:TeamMember
    {
        public Administrator(string name) : base(name)
        {

        }

        public override void Recieve(string from, string message)
        {
            
            Console.WriteLine($"{this.name} ({nameof(Administrator)}) has recieved: ");
            base.Recieve(from, message);
        }
    }
}
