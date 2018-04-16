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
            Book book = new Book("authotName", "bookTitle", "bookContent");
            book.Show();
            Console.ReadKey();
        }
    }
}
