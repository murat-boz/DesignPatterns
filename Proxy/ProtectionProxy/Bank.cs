using System;

namespace ProtectionProxy
{
    public sealed class Bank : IBank
    {
        public bool Pay(decimal amount)
        {
            if (amount < 100)
            {
                Console.WriteLine("The amount you will pay cannot be less than 100$.");

                return false;
            }

            Console.WriteLine("Payment made successfully");

            return true;
        }
    }
}
