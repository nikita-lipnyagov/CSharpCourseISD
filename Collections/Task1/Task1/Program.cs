using System;
using System.Collections;
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
            MyNumberCollection numbers = new MyNumberCollection(new int[] { 1, 2, 3, 4, 5, 6 });

            foreach(var item in numbers.GetEvenNumbers())
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }

        public class MyNumberCollection
        {
            private int[] array;

            public MyNumberCollection(int[] array)
            {
                this.array = array;
            }

            public IEnumerable<int> GetEvenNumbers()
            {
                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] % 2 == 0)
                    {
                        yield return array[index];
                    }
                }
            }
        }

    }
}
