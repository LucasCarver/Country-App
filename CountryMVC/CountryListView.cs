using System;
using System.Collections.Generic;
using System.Text;

namespace CountryMVC
{
    class CountryListView
    {
        public List<Country> Countries;
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            Country c;
            for (int i = 0; i < Countries.Count; i++)
            {
                c = Countries[i];
                Console.WriteLine($"{i}: {c.Name}");
            }
        }
    }
}