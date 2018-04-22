using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            while (counter < number / 2 + 1)
            {
                if (number % counter == 0)
                {

                    Console.WriteLine("Number isn`t prime");
                    return;
                }
                counter++;
            }
            Console.WriteLine("Number is prime");
            Console.ReadKey();
        }
    }
}
