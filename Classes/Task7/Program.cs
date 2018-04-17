using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{

public class Employee
{
    private string family;
    private string name;

    public string position;
    public float experience;
    public int salary;
    public int tax;

    public Employee(string lastName, firstName){
        this.family = lastName;
        this.name = firstName;
    }

    public void countSalaryAndTax(){
        if(position == 'junior'){
            if(experience < 1){
                salary = 500;
            }
            else{
                salary = 700;
            }
        }
        else if(position == 'middle'){
            if(experience < 2){
                salary = 1000;
            }
            else{
                salary = 1500;
            }
        }
        else if(position == 'senior'){
             if(experience < 3){
                salary = 2000;
            }
            else{
                salary = 3000;
            }
        }

        tax = salary*0.15;
    }

    public void Show(){
        countSalaryAndTax();
        Console.WriteLine(lastName + ' ' + firstName + ' - ' + position);
        Console.WriteLine('Salary: ' + salary);
        Console.WriteLine('Tax: ' + tax);

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
