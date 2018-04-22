using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            float average, sum = 0;
            Console.WriteLine("Ввдедите 5 целых чисел: ");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Int32.Parse(Console.ReadLine());
                sum += nums[i];
            }
            average = sum/nums.Length;
            Console.WriteLine("Среднее арифметическое этих чисел: " + average);

            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
