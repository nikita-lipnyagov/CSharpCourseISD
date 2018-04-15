using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress("0056","Ukraine","-","Polya","11","3a");
            adress.City = "Dnipro";
            Console.WriteLine(adress.ToString());
            Console.ReadKey();
        }
    }
}
