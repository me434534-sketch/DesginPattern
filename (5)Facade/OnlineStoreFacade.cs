using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _5_Facade
{
    internal class OnlineStoreFacade
    {
        private InventoryManager inventory = new InventoryManager();
        private PaymentProcessor payment = new PaymentProcessor();
        private ShippingManager shipping = new ShippingManager();

        public void PlaceOrder(string product, int amount)
        {
            inventory.CheckStock(product);
            payment.ProcessorPayment(product, amount);
            shipping.ShipProduct(product);
            Console.WriteLine("Order placed successfully!\n");
        }
    }
}
