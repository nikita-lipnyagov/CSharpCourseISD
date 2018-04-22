using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдедите число(1 или 0): ");
            int a = Int32.Parse(Console.ReadLine());

            if(a == 0){
                Console.WriteLine("Плохо");
            }
            else if(a == 1){
                Console.WriteLine("Хорошо");
            }
            else{
                Console.WriteLine("Данные введены некорректно!");
            }
           
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
