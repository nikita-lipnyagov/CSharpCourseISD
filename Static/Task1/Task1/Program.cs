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
            Console.WriteLine("5 + 3 = " +  Calculator.sum(5, 3));
            Console.WriteLine("15 - 4 = " + Calculator.minus(15, 4));
            Console.WriteLine("4 * 12 = " + Calculator.multiply(4, 12));
            Console.WriteLine("16 / 2 = " + Calculator.divide(16, 2));

            Console.ReadKey();
        }
    }
}
