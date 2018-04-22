using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] nums = new int[5];

            float average, sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(-50,50);
                sum += nums[i];
            }
            average = sum/nums.Length;
            Console.WriteLine("Среднее арифметическое 5 случайных чисел: " + average);

            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
