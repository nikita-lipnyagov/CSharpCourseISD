using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Author
    {
        public String author;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" author: " + author + "; ");
            Console.ResetColor();
        }
    }
}
