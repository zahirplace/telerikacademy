using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            /*
            01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
            */

            Console.WriteLine("Insert a year to check: ");

            string year_tmp = Console.ReadLine();
            int year;
            if (int.TryParse(year_tmp, out year))
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine("Year {0} is a leap year!", year);
                }
                else
                {
                    Console.WriteLine("Year {0} is NOT a leap year!", year);
                }
            }
            else
            {
                Console.WriteLine("Incorrect Year!");
            }

        }

        static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
