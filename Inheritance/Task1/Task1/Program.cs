using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {

            ColorPrinter printer1 = new ColorPrinter(ConsoleColor.Blue);
            printer1.Print("color printer");

            ColorPrinter printer2 = new ColorPrinter(ConsoleColor.Red);
            printer2.Print("color printer");

            Printer printer3 = new ColorPrinter(ConsoleColor.Green);
            printer3.Print("color printer");

            Printer colorPrinter = new ColorPrinter();

            Printer printer = colorPrinter;
            printer.Print("printer");

            Printer defaultPrinter = new Printer();
            printer.Print("default printer");

            Console.ReadKey();
        }
    }

    class Printer
    {
        public Printer(){}

        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
        }
    }

    class ColorPrinter : Printer
    {
        protected ConsoleColor color;

        public ColorPrinter() {
            color = ConsoleColor.White;
        }

        public ColorPrinter(ConsoleColor color)
        {
            this.color = color;
        }

        public override void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
