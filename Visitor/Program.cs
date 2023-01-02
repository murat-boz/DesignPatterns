using System;
using Visitor.Concrete;
using Visitor.VisitorConcrete;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia       = new Nokia();
            Ericsson ericsson = new Ericsson();

            nokia.SendMessage();
            nokia.Call();

            ericsson.SendMessage();
            ericsson.Call();

            InternetVisitor internetVisitor = new InternetVisitor();

            nokia.Accept(internetVisitor);
            ericsson.Accept(internetVisitor);

            Console.ReadLine();
        }
    }
}
