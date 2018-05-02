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
            int number = MyClass<int>.FactoryMethod(10);
            Console.WriteLine("Number: " + number);

            char ch = MyClass<char>.FactoryMethod('a');
            Console.WriteLine("Char: " + ch);

            Console.ReadKey();
        }
    }

    class MyClass<T> where T: new()
    {
       public static T FactoryMethod(T value)
       {
            return value;
       }
    }
}
