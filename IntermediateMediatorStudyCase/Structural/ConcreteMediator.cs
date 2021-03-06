using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateMediatorStudyCase.Structural
{
    public class ConcreteMediator : Mediator
    {
        //public Colleague1 Colleague1 { get; set; }
        //public Colleague2 Colleague2 { get; set; }

        private List<Colleague> colleagues = new();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
        }
        public T CreateColleague<T>() where T:Colleague, new()
        {
            var c = new T();
            c.SetMediator(this);
            return c;
        }

        public override void Send(string message, Colleague colleague)
        {

            this.colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
            //if (colleague == this.Colleague1)
            //{
            //    this.Colleague2.HandleNotification(message);
            //}
            //else
            //{
            //    this.Colleague1.HandleNotification(message);
            //}

        }
    }
}
