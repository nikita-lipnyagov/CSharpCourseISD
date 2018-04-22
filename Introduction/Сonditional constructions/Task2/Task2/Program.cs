using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String signal;

            Console.WriteLine("Enter animal signal: ");
            signal = Console.ReadLine();

            if (signal.Equals("гав"))
            {
                Console.WriteLine("Погуляй с собакой");
            }
            else if(signal.Equals("мяу"))
            {
                Console.WriteLine("Покорми кота");
            }
            else
            {
                Console.WriteLine("Что-то пошло не так");
            }

            Console.ReadKey();
        }
    }
}
