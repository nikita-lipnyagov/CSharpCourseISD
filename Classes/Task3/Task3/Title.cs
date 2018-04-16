using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Title
    {
        public String title;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" title: " + title + "; ");
            Console.ResetColor();
        }
    }
}
