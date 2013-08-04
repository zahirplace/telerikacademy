using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitsArray
{
    class DigitsArray
    {

        static void Main(string[] args)
        {
            /*8. Write a method that adds two positive integer numbers represented as arrays of digits 
             (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
             Each of the numbers that will be added could have up to 10 000 digits. 
             */

            List<int> firstNumber  = new List<int>() { 3, 2, 1 };
            List<int> secondNumber = new List<int>() { 2, 1, 0 };

            Console.WriteLine(AddNumbers(firstNumber, secondNumber));
        }

        static int AddNumbers(List<int> firstNumber, List<int> secondNumber)
        {
            int firstNum = ArrToDecimal(firstNumber);
            int secondNum = ArrToDecimal(secondNumber);
            return firstNum + secondNum;
        }

        static int ArrToDecimal(List<int> digitArray)
        {
            int number = 0;
            foreach (int num in digitArray)
            {
                number = number * 10 + num;
            }
            return number;
        }
    }
}
