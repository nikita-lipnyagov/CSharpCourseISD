using System;

namespace Task4
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
            int j=0, index = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == str1[j]){
                    if((j+1) == (str1.Length)){
                        return i-j;
                    }
                    j++;
                }
                else{
                    j = 0;
                }
            }
            return index;
        }
        public static string Replace(string str1, string str2){
            int j=0;
            string str3 = "";

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] == str1[j]){
                    if((j+1) == (str1.Length)){
                        int first = i-j, second = i+1;

                        for (int k = 0; k < first; k++)
                        {
                            str3 += str[k];
                        }
                        str3 += str2;
                        for (int k = second; k < str.Length; k++)
                        {
                            str3 += str[k];
                        }

                        return str3;
                    }
                    j++;
                }
                else{
                    j = 0;
                } 
            }
            
            return str3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Functions.Substring(4,8));
            Console.WriteLine(Functions.IndexOf("World"));
            Console.WriteLine(Functions.Replace("World", "Alexander"));
        
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
