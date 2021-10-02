using IntermediateMediatorStudyCase.Structural;
using System;

namespace IntermediateMediatorStudyCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var c1 = new Colleague1();
            var c2 = new Colleague2();
            //       Refactor
            //mediator.Colleague1 = c1;
            //mediator.Colleague2 = c2;
           
            // Option 1:
            mediator.Register(c1);
            mediator.Register(c2);
            // bi directional refferences

            //option 2:
            var D1 = mediator.CreateColleague<Colleague1>();
            var D2 = mediator.CreateColleague<Colleague2>();

            c1.Send("Hello, World (From c1)");
            c2.Send("Hi there! (From c2)");

            D1.Send("Hello, World (From big C1)");
            D2.Send("Hi there! (From big C2)");

        }
    }
}
