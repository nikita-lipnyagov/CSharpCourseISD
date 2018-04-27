using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdayDate;

            Console.WriteLine("Dear user, enter your birthday date (yyyy-MM-dd): ");

            try
            {
                string dateStr = Console.ReadLine();

                birthdayDate = DateTime.ParseExact(dateStr, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                DateTime nextYearBirhdayDay = new DateTime(DateTime.Now.Year + 1, birthdayDate.Month, birthdayDate.Day);

                int dayDifference = (nextYearBirhdayDay - DateTime.Now).Days;

                if (dayDifference > 365)
                {
                    dayDifference -= 365;
                }

                Console.WriteLine("Days for your next birthday: " + dayDifference);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
