using System;

namespace Task3
{
    class Dictionary<TKey,TValue>
    {
        private int counter = 0;
        private TKey[] key;
        private TValue[] value;
        public int Counter
        {
            get{ return this.counter; }
        }

        public void Add(TKey curKey, TValue curValue){
            counter++;

            Array.Resize(ref key, counter);
            key[counter-1] = curKey;

            Array.Resize(ref value, counter);
            value[counter-1] = curValue; 
        }
        public TValue this[TKey key]
        {
            get
            {
                int index = 0;
                for (int i = 0; i < this.key.Length; i++)
                {
                    if (key.Equals(this.key[i]))
                        index = i;
                }
                return value[index];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1,"first");
            dictionary.Add(2,"second");
            dictionary.Add(3,"third");

            Console.WriteLine("Общее количество пар элементов: " + dictionary.Counter);
            Console.WriteLine("Значение элемента по указанному индексу: " + dictionary[1]);
            
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
