using System;

namespace Task1
{
    abstract class AbstractHandler
    {
        abstract public void Open();

        abstract public void Create();

        abstract public void Change();

        abstract public void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler()
        {
            Console.WriteLine("It's XML file!");
        }
        public override void Open()
        { 
            Console.WriteLine("XML file is open!");
        }

        public override void Create()
        { 
            Console.WriteLine("XML file was created!");
        }

        public override void Change()
        { 
             Console.WriteLine("XML file was changed!");
        }

        public override void Save()
        { 
             Console.WriteLine("XML file was saved!");
        }
    }

     class TXTHandler : AbstractHandler
    {
        public TXTHandler()
        {
            Console.WriteLine("It's TXT file!");
        }
        public override void Open()
        { 
            Console.WriteLine("TXT file is open!");
        }

        public override void Create()
        { 
            Console.WriteLine("TXT file was created!");
        }

        public override void Change()
        { 
             Console.WriteLine("TXT file was changed!");
        }

        public override void Save()
        { 
             Console.WriteLine("TXT file was saved!");
        }
    }

     class DOCHandler : AbstractHandler
    {
        public DOCHandler()
        {
            Console.WriteLine("It's DOC file!");
        }
        public override void Open()
        { 
            Console.WriteLine("DOC file is open!");
        }

        public override void Create()
        { 
            Console.WriteLine("DOC file was created!");
        }

        public override void Change()
        { 
             Console.WriteLine("DOC file was changed!");
        }

        public override void Save()
        { 
             Console.WriteLine("DOC file was saved!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler xml_file = new XMLHandler();
            xml_file.Create();
            xml_file.Open();
            xml_file.Change();
            xml_file.Save();

            AbstractHandler txt_file = new TXTHandler();
            txt_file.Create();
            txt_file.Open();
            txt_file.Change();
            txt_file.Save();

            AbstractHandler doc_file = new DOCHandler();
            doc_file.Create();
            doc_file.Open();
            doc_file.Change();
            doc_file.Save();

            Console.ReadKey();
        }
    }
}
