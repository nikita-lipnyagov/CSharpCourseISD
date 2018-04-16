using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        Author author = new Author();
        Title title = new Title();
        Content content = new Content();

        public Book(String authorName, String bookTitle, String bookContent)
        {
            this.author.author = authorName;
            this.title.title = bookTitle;
            this.content.content = bookContent;
        }

        public void Show()
        {
            Console.WriteLine("BOOK:");
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
