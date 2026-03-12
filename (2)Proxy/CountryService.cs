using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Proxy
{
    internal class CountryService : ICountry
    {
        public void GetCountries()
        {
            Console.WriteLine("Getting Countries from server");
        }
    }
}
