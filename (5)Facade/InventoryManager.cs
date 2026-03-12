using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Facade
{
    internal class InventoryManager
    {
        public void CheckStock(string product)
        {
            Console.WriteLine($"Checking stock for {product}...");
        }
    }
}
