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
            int[] array = new int[5] { 8, 3, 1, 9, 0 };
            MyArray.BubbleSort(array);

            foreach (int x in array)
                Console.Write(x + " ");

            Console.ReadKey();
        }
    }
}
