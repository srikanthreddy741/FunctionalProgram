using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProblems
{
    public class LeapYear
    {
        public static void Year()
        {
            int year;
            Console.WriteLine("Enter the year in four digits : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is leap year ", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year ", year);
            }
            Console.ReadLine();
        }
    }
}
