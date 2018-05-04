using System;
using System.Collections;
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
            MyList<String> list = new MyList<string>(10);
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.Add("five");

            foreach(var item in list.GetList())
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }

    class MyList<T>
    {
        private static int size;
        private T[] array;

        private static int currentSize = 0;

        public int Count
        {
            get { return currentSize; }
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public MyList(int capacity)
        {
            size = capacity;
            array = new T[size];
        }

        public void Add(T item)
        {
            if (currentSize < size)
            {
                array[currentSize] = item;
                currentSize++;
            }
            else
            {
                size++;

                Array.Resize<T>(ref array, size);
                array[currentSize] = item;
                currentSize++;
            }
        }

        public IEnumerable GetList()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}
