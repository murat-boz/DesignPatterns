using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Customer customer = new Customer();

            product.ObserverList.Add(customer);

            product.Exist = true;

            Console.ReadLine();
        }
    }
    
}
