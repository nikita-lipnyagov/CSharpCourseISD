using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдедите номер дня недели: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскреснье");
                    break;
                default:
                    Console.WriteLine("Данные введены некорректно!");
                    break;
            }
           
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
