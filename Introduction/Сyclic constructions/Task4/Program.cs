using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдедите число N: ");
            int n = Int32.Parse(Console.ReadLine());

            int square;
            for (int i = 1; ; i++)
            {
                square = i*i;
                if (square > n) break;
                Console.WriteLine(i + " - " + square);
            }

            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
