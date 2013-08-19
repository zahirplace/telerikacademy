using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaysOfWeek
{
    class DaysOfWeek
    {
        static void Main(string[] args)
        {
            /*
            03. Write a program that prints to the console which day of the week is today. Use System.DateTime.
            */

            Console.WriteLine("Today is {0}!", DateTime.Today.DayOfWeek.ToString());
        }
    }
}
