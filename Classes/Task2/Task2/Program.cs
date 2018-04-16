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
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine("Area: " + rectangle.Area);
            Console.WriteLine("Perimeter: " + rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
