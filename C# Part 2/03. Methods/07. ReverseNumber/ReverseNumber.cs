using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            /*7. Write a method that reverses the digits of given decimal number. Example: 256 -> 652 */

            int numberToReverse = 256;
            Console.WriteLine("The reversed number of {0} is {1}.", numberToReverse, ReverseNumberM(numberToReverse));
        }

        static int ReverseNumberM(int num)
        {
            int reversedNumber = 0;

            while (num > 0)
            {
                reversedNumber = reversedNumber * 10 + num % 10;
                num /= 10;
            }
            return reversedNumber;
        }
    }
}