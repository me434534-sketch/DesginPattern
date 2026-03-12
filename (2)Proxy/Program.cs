namespace _2_Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICountry proxy = new CountryProxy();

            proxy.GetCountries();
            proxy.GetCountries();
        }
    }
}
