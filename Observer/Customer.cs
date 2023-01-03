using System;

namespace Observer
{
    public class Customer : Observer
    {
        public override void Update()
        {
            Console.WriteLine($"The customer has been warned about the product is not exist anymore");
        }
    }
}
