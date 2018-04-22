using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите ставку: ");
            int rate = Int32.Parse(Console.ReadLine());
            int number = new Random().Next(1, 13);
            int sum = 0;

            Console.WriteLine("Выпала грань " + number);

            if (number <= 5)
            {
                Console.WriteLine("Вы проиграли...");
            }
            else if(number <= 8)
            {
                Console.WriteLine("Вы вернули свои деньги обратно...");
                sum = rate;

            }
            else if(number <= 11)
            {
                Console.WriteLine("Вы выиграли двойную ставку...");
                sum = rate * 2;
            }
            else
            {
                Console.WriteLine("Вы выиграли 10x ставку...");
                sum = rate * 10;
            }

            Console.Write("Ваша сумма после броска кубика: " + sum);
            Console.ReadKey();
        }
    }
}
