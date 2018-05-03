using System;

namespace Task7
{
    class ArrayList{
        private int[] array;
        private int size = 0;

        public int getSize
        {
            get{ return this.size; }
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public void Add(int curValue){
            size++;

            Array.Resize(ref array, size);
            array[size-1] = curValue; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(548);
            list.Add(1409);
            list.Add(89456);
            Console.WriteLine("Последнне число в списке: " + list[2]);

            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
