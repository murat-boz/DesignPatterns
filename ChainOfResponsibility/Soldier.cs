using System;

namespace ChainOfResponsibility
{
    public class Soldier : Chain<Competency>
    {
        public override void Handle(Competency request)
        {
            if (request != Competency.Soldier)
            {
                Console.WriteLine("Soldier's competency is not enough");

                base.next.Handle(request);
            }
            else
            {
                Console.WriteLine("Soldier's competency is enough");
            }
        }
    }
}
