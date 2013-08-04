using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReturnWord
{
    class ReturnWord
    {
        static void Main(string[] args)
        {
            /*
           3.  Write a method that returns the last digit of given integer as an English word. 
           Examples: 512 -> "two", 1024 > "four", 12309 -> "nine".
           */

            Console.WriteLine("number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The last digit is '{0}'!", GetNumberName(num)); //First version
            Console.WriteLine("The last digit is '{0}'!", GetNumberNameSwitch(num));//Second version
        }

        static string GetNumberName(int num)
        {
            int digit = num % 10;
            string[] numberNames = new string[]
                { 
                "zero", "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine"
                };
            return numberNames[digit];
        }

        static string GetNumberNameSwitch(int num)
        {
            int digit = num % 10;
            string monthName;
            switch (digit)
            {
                case 0: monthName = "zero"; break;
                case 1: monthName = "one"; break;
                case 2: monthName = "two"; break;
                case 3: monthName = "three"; break;
                case 4: monthName = "four"; break;
                case 5: monthName = "five"; break;
                case 6: monthName = "six"; break;
                case 7: monthName = "seven"; break;
                case 8: monthName = "eight"; break;
                case 9: monthName = "nine"; break;
                default: monthName = "Wrong number!!!"; break; //never process in the case
            }
            return monthName;
        }

    }
}
