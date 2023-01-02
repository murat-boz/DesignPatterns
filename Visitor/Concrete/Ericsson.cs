using System;

namespace Visitor.Concrete
{
    public class Ericsson : IPhone
    {
        public void Accept(IPhoneVisitor phoneVisitor)
        {
            phoneVisitor.Visit(this);
        }

        public void Call()
        {
            Console.WriteLine($"Called from {nameof(Ericsson)}");
        }

        public void SendMessage()
        {
            Console.WriteLine($"Sent message from {nameof(Ericsson)}");
        }
    }
}
