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
            Console.WriteLine("Enter a:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = Int32.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("Max is " + a);
            }
            else
            {
                Console.WriteLine("Max is " + b);
            }

            Console.ReadKey();
        }
    }
}
