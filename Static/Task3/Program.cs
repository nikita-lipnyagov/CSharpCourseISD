using System;

namespace Task3
{
    static class Functions
    {
        static string str;
        static Functions(){
            str = "Hello, World!";
        }
        public static string Substring(int startIndex, int length){
            string subStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if(i>=startIndex && i<=length){
                    subStr += str[i];
                }
            }
            return subStr;
        }
        public static int IndexOf(string str1){
            int index = -1;
            return index;
        }
        public static void Replace(string str1, string str2){

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Functions.Substring(4,8));
            
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
