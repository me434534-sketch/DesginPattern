using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Facade
{
    internal class PaymentProcessor
    {
        public void ProcessorPayment(string product, int amount)
        {
            Console.WriteLine($"Processing payment of ${amount} for {product}...");

        }
    }
}
