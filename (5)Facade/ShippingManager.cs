using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Facade
{
    internal class ShippingManager
    {
        public void ShipProduct(string product)
        {
            Console.WriteLine($"Shipping {product} to customer...");
        }
    }
}
