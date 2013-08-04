using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiggerThanNeighbors
{
    class BiggerThanNeighbors
    {
        static void Main(string[] args)
        {
            /*5. Write a method that checks if the element at given position in given array of integers is bigger than 
             its two neighbors (when such exist). 
             */

            int[] arrOfInteger = { 1, 2, 9, 8, 10, 7, 4, 5 };
            int index = 4;
            //int index = 6;
           // int index = 0;
            //int index = 7;

            Console.WriteLine("The element {0} at position {1} {2} bigger than its neighbors!",
                              arrOfInteger[index], index, IsBigger(index, arrOfInteger)?"IS":"ISN'N");            
        }

        static bool IsBigger(int index, int[] intArr)
        {
            if (index == 0)
            {
                return intArr[index] > intArr[index + 1];
            }

            if (index == intArr.Length - 1)
            {
                return intArr[index] > intArr[index - 1];
            }

            if (intArr[index] <= intArr[index - 1])
            {
                return false;
            }
            else
            {
                return intArr[index] > intArr[index + 1];
            }

        }

    }
}
