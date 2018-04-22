using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double grivna = 0, dollar = 0, euro = 0;
            int currency = 0;

            Console.WriteLine("Введите сумму: ");
            double sum = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Что это за валюта? 1-гривна, 2-доллар, 3-евро");
            while(currency < 1 || currency > 3)
            {
                currency = Int32.Parse(Console.ReadLine());
            }
       
            switch(currency)
            {
                case 1:
                    grivna = sum;
                    dollar = 26.2 * sum;
                    euro   = 32.2 * sum;
                    break;
                case 2:
                    dollar = sum;
                    grivna = 26.2 * sum;
                    euro   = 1.23 * sum;
                    break;
                case 3:
                    euro   = sum;
                    dollar = 0.81 * sum;
                    grivna = 32.2 * sum;
                    break;
            }

            Console.WriteLine("Гривна: " + grivna);
            Console.WriteLine("Доллар: " + dollar);
            Console.WriteLine("Евро: " + euro);

            Console.ReadKey();
        }
    }
}
