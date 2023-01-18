using System;

namespace ChainOfResponsibility
{
    public class General : Chain<Competency>
    {
        public override void Handle(Competency request)
        {
            if (request != Competency.General)
            {
                Console.WriteLine("Soldier's competency is not enough");

                base.next.Handle(request);
            }
            else
            {
                Console.WriteLine("General's competency is enough");
            }
        }
    }
}
