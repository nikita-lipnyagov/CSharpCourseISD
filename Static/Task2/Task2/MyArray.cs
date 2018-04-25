using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class MyArray
    {
        public static void BubbleSort(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int z = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = z;
                    }
                }
            }
        }
    }
}
