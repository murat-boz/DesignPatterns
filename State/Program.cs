using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterNameContext printerNameContext = new PrinterNameContext();

            Console.WriteLine(printerNameContext.GetName());

            Console.ReadLine();
        }
    }
}
