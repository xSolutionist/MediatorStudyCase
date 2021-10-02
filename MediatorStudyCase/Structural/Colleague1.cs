using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorStudyCase.Structural
{
    public class Colleague1 : Colleague
    {
        public Colleague1(Mediator mediator) : base(mediator)
        {

        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 recieves notification message: {message}");
        }
    }
}
