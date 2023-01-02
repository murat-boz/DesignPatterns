using System;

namespace Visitor.Concrete
{
    public class Nokia : IPhone
    {
        public void Accept(IPhoneVisitor phoneVisitor)
        {
            phoneVisitor.Visit(this);
        }

        public void Call()
        {
            Console.WriteLine($"Called from {nameof(Nokia)}");
        }

        public void SendMessage()
        {
            Console.WriteLine($"Sent message from {nameof(Nokia)}");
        }
    }
}
