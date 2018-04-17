using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{

    class User
    {
        private string login;
        private string firstName;
        private string secondName;
        private int age;
        private DateTime date;

        User (string login, string firstName, string secondName, int age, DateTime date)
        {
            this.login = login;
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
            this.date = date;
            Console.Write(login + "" + firstName + "" + secondName + "" + age + "" + date);
        }



    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
