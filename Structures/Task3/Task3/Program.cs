using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("не изменено");
            MyStruct myStruct = new MyStruct("не изменено");

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine("Class: " + myClass.change);
            Console.WriteLine("Structure: " + myStruct.change);

            Console.ReadLine();
        }
    }
}
