using System;
using System.IO;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating of file
                StreamWriter textFile = new StreamWriter(Path.GetFullPath(@"text.txt"));
                textFile.WriteLine("Text file was created!");
                textFile.Close();

                //Reading this file
                using (StreamReader sr = new StreamReader(Path.GetFullPath(@"text.txt"), Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
