using System;

namespace ProtectionProxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "", userPassword = "";

            decimal amount = 0;

            while (true)
            {
                Console.WriteLine("Please enter your username.");
                userName = Console.ReadLine();

                Console.WriteLine("Please enter your password.");
                userPassword = Console.ReadLine();

                Console.WriteLine("Please enter the amount to be paid.");
                amount = Convert.ToInt32(Console.ReadLine());

                IBank banka = new ProxyBank(userName, userPassword);
                banka.Pay(amount);

                Console.WriteLine("************");
            }
        }
    }
}
