using System;

namespace Task1
{
    class Program
    {
        struct Notebook
        {
            string model;
            string producer;
            float price;

            public Notebook(string model, string producer, float price){
                this.model = model;
                this.producer = producer;
                this.price = price;
            }
            public void Print(){
                Console.WriteLine("Notebook's model: " + model);
                Console.WriteLine("Notebook's producer: " + producer);
                Console.WriteLine("Notebook's price: " + price);
            }
        }
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Spider", "Akvarel", 158);
            notebook.Print();

            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
