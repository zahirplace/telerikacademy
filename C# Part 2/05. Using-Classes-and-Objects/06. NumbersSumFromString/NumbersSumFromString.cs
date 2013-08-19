using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersSumFromString
{
    class NumbersSumFromString
    {
        static void Main(string[] args)
        {
            /*
            06. You are given a sequence of positive integer values written into a string, separated by spaces. 
            Write a function that reads these values from given string and calculates their sum. 
            Example:    string = "43 68 9 23 318" -> result = 461
            */

            Console.WriteLine("Write a sequence of positive integer values, separated by a space, and press ENTER:");
            string strNumbers = Console.ReadLine();
            Console.WriteLine("The sum of numbers is {0}.", GetSumFromStringNumbers(strNumbers));

        }

        static int GetSumFromStringNumbers(string strNumbers)
        {
            string[] strNumArray = strNumbers.Split(' ');
            int Sum = 0;
            foreach (string num in strNumArray)
            {
                Sum += int.Parse(num);
            }
            return Sum;
        }
    }
}
