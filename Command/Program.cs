using System;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorManager calculatorManager = new CalculatorManager();

            calculatorManager.Compute('+', 50);
            calculatorManager.Compute('-', 25);
            calculatorManager.Compute('*', 50);
            calculatorManager.Compute('/', 10);
            calculatorManager.Compute('+', 75);

            calculatorManager.Undo();
            calculatorManager.Undo();
            calculatorManager.Undo();

            Console.ReadLine();
        }
    }
}
