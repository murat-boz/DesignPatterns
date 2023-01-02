using System;
using Visitor.Concrete;

namespace Visitor.VisitorConcrete
{
    public class InternetVisitor : IPhoneVisitor
    {
        public void Visit(Nokia phone)
        {
            Console.WriteLine($"Connected to internet from {nameof(Nokia)}");
        }

        public void Visit(Ericsson phone)
        {
            Console.WriteLine($"Connected to internet from {nameof(Ericsson)}");
        }
    }
}
