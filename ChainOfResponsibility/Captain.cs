using System;

namespace ChainOfResponsibility
{
    public class Captain : Chain<Competency>
    {
        public override void Handle(Competency request)
        {
            if (request != Competency.Captain)
            {
                Console.WriteLine("Captain's competency is not enough");

                base.next.Handle(request);
            }
            else
            {
                Console.WriteLine("Captain's competency is enough");
            }
        }
    }
}
