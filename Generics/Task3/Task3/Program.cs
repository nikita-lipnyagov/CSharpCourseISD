using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");

            Console.WriteLine("dictionary[2] = " + dictionary[2]);
            Console.WriteLine("Current size = " + dictionary.Count);

            Console.ReadKey();
        }
    }

    class MyDictionary<TKey, TValue>
    {
        private int counter = 0;
        private TKey[] keys = null;
        private TValue[] values = null;

        public int Count
        {
            get { return this.counter; }
        }

        public void Add(TKey key, TValue val)
        {
            this.counter++;

            Array.Resize(ref keys, counter);
            keys[counter - 1] = key;

            Array.Resize(ref values, counter);
            values[counter - 1] = val;
        }

        public TValue this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < keys.Length; i++)
                {
                    if (key.Equals(keys[i]))
                        index = i;
                }
                return values[index];
            }
        }
    }
}
