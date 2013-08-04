using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiggerNumber
{
    class BiggerNumber
    {
        static void Main(string[] args)
        {

            /* Write a method GetMax() with two parameters that returns the bigger of two integers. 
             Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
             */

            Console.WriteLine("Insert");
            Console.WriteLine("number 1: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("number 2: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("number 3: ");
            int thirdNum = int.Parse(Console.ReadLine());

            int maxNum = GetBiggerNumber(firstNum, secondNum);
            maxNum = GetMax(maxNum, thirdNum);
            Console.WriteLine("(variant 1) The biggest number is = {0}", maxNum);

            maxNum = GetMax(firstNum, secondNum, thirdNum);
            Console.WriteLine("(variant 2) The biggest number is = {0}", maxNum);
        }
        
        static int GetMax(params int[] intArray)
        {

            int maxNumber = intArray[0];
            foreach (int num in intArray)
            {
                if (num > maxNumber)
                {
                    maxNumber = num;
                }

            }
            return maxNumber;
        }

        static int GetBiggerNumber(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);

            /*
            //II n-n:
            int max = firstNum;
            if (secondNum > max)
            {
                max = secondNum;
            }
            return max;
             */
        }
    }
}
