using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int pay;
            Console.WriteLine("Подсчет оплаты за проезд\n");

            Console.WriteLine("Ввдедите количество километров: ");
            int km = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ввдедите количество минут простоя: ");
            int min = Int32.Parse(Console.ReadLine());

            if(km<=5){
                pay = 20 + min;
            }
            else{
                pay = 20 + min + (km-5)*3;
            }

            Console.WriteLine("Общая сумма оплаты за проезд: " + pay + "грн.");

            Console.WriteLine("Для завершения работы программы нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
