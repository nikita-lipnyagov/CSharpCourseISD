using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Content
    {
        public String content;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" content: " + content + "; ");
            Console.ResetColor();
        }
    }
}
