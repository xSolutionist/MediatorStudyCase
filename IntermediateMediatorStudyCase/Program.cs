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
            //mediator.Colleague1 = c1;
            //mediator.Colleague2 = c2;
            mediator.Register(c1);
            mediator.Register(c2);
            // bi directional refferences

            c1.Send("Hello, World (From c1)");
            c2.Send("Hi there! (From c2)");

            Console.ReadLine();
        }
    }
}
