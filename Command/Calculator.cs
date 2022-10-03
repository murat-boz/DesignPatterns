using System;

namespace Command
{
    /// <summary>
    /// Receiver class
    /// </summary>
    public class Calculator
    {
        public decimal Value { get; set; }

        public decimal Compute(char @operator, decimal value)
        {
            switch (@operator)
            {
                case '+':
                    this.Value += value;
                    break;
                case '-':
                    this.Value -= value;
                    break;
                case '/':
                    this.Value /= value;
                    break;
                case '*':
                    this.Value *= value;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"'{@operator}' process has been compute. Value: {this.Value}");

            return this.Value;
        }
    }
}
