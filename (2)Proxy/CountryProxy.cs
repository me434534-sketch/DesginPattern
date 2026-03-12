using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Proxy
{
    internal class CountryProxy:ICountry
    {
        CountryService service = new CountryService();
        bool cached = false;

        public void GetCountries()
        {
            if (!cached)
            {
                service.GetCountries();
                Console.WriteLine("Data cashed"); ;
                cached = true;
            }
            else
            {
                Console.WriteLine("Getting countries from cached"); 
            }
        }
    }
}
