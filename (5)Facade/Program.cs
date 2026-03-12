namespace _5_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineStoreFacade store = new OnlineStoreFacade();

            store.PlaceOrder("x", 1200);
            store.PlaceOrder("y", 800);
        }
    }
}
