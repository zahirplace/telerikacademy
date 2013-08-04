using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxAppearance
{
    class MaxAppearance
    {
        static void Main(string[] args)
        {
            /*4. Write a method that counts how many times given number appears in given array.
             Write a test program to check if the method is working correctly. */

            int searchDig = 9;
            int[] arrOfNumbers = { 2, 3, 7, 44, 61, 2, 3, 9, 5, 9, 7, 8, 9, 2 };

            //first variant
            Console.WriteLine("The number {0} appears {1} times.", searchDig, GetDigitCount(searchDig, arrOfNumbers));
            //second variant
            Console.WriteLine("The number {0} appears {1} times.", searchDig, GetDigitCountSecond(arrOfNumbers, searchDig, arrOfNumbers.Length));
        }

        static int GetDigitCountSecond(int[] arrOfNumbers, int searchDig, int length)
        {
            int[] listEqualNum = new int[length];
            listEqualNum = Array.FindAll(arrOfNumbers, num => num == searchDig);
            return listEqualNum.Length;
        }

        static int GetDigitCount(int number, int[] numArr)
        {
            int numCount = 0;
            foreach (int ArrElem in numArr)
            {
                if (ArrElem == number)
                {
                    numCount++;
                }
            }
            return numCount;
        }
    }
}
