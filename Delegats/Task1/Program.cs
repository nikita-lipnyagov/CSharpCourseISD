using System;

namespace Task1
{
    class Program
    {
        delegate int Method(int num1, int num2, int num3);

        static void Main(string[] args)
        {
            Method average = (int num1, int num2, int num3) => (num1 + num2 + num3)/3;
            Console.WriteLine("Среднее арифметическое выбраныных чисел: " + average(10,20,30));
            
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
