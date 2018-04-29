using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats
{
    class Calculator
    {
        delegate double Add(double x, double y);
        delegate double Sub(double x, double y);
        delegate double Mul(double x, double y);
        delegate double Div(double x, double y);

        static void Main(string[] args)
        {
            Add add = (x, y) => x + y;
            Sub sub = (x, y) => x - y;
            Sub mul = (x, y) => x * y;
            Div div = (x, y) =>
            {
                if (y != 0)
                {
                    return x / y;
                }
                throw new Exception("y = 0");
            };

            //Test program
            Console.WriteLine("3 + 5 = " + add(3, 5));
            Console.WriteLine("4 - 1 = " + sub(4, 1));
            Console.WriteLine("8 * 4 = " + mul(8, 4));
            Console.WriteLine("16 / 4 = " + div(16, 4));
            Console.ReadKey();
        }
    }
}
