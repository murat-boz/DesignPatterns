using System;

namespace ChainOfResponsibility
{
    public class Lieutenant : Chain<Competency>
    {
        public override void Handle(Competency request)
        {
            if (request != Competency.Lieutenant)
            {
                Console.WriteLine("Lieutenant's competency is not enough");

                base.next.Handle(request);
            }
            else
            {
                Console.WriteLine("Lieutenant's competency is enough");
            }
        }
    }
}
