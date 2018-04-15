using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Adress
    {
        public String Index { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String House { get; set; }
        public String Apartment { get; set; }

        public Adress(){}

        public Adress(String index, String country, String city, String street, String house, String apartment)
        {
            Index = index;
            Country = country;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public override string ToString()
        {
            return "Adress: " + Index +", " + Country + ", " + City + ", " + Street + ", " + House + ", " + Apartment;
        }
    }
}
