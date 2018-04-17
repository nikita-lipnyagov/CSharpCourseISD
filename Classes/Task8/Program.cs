using System;

namespace Task8
{

public class Invoice
{
    private const int account = 178430;
    private const string customer = "Ivan";
    private const string provider = "Petr";

    public string article;
    public int quantity;
    public int price;

    public void paymentWithoutVAT(){
        int orderCost = price*quantity;
        Console.WriteLine("Payment without VAT: " + orderCost);
    }

    public void paymentWithVAT(){
        int orderCost = price*quantity*0.2;
        Console.WriteLine("Payment with VAT: " + orderCost);
    }

    public void Show(){
        paymentWithoutVAT();
        paymentWithVAT();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

}