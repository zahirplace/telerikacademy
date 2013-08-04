using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindElemByIndexAndSortArray
{
    class FindElemByIndexAndSortArray
    {
        static void Main(string[] args)
        {
            /*9. Write a method that return the maximal element in a portion of array of integers starting at given index. 
             Using it write another method that sorts an array in ascending / descending order.
            */

            int[] arrOfNumbers = { 6, 2, 9, 8, 10, 7, 4, 5 };
            int startIndex = 3;

            PrintArray(arrOfNumbers);
            SortArrayFromIndexAscending(arrOfNumbers, startIndex);
            PrintArray(arrOfNumbers);
            SortArrayFromIndexDescending(arrOfNumbers, startIndex);
            PrintArray(arrOfNumbers);
        }

        static void SortArrayFromIndexDescending(int[] arrOfNumbers, int startIndex)
        {
            SortArrayFromIndexAscending(arrOfNumbers, startIndex);
            Array.Reverse(arrOfNumbers);
        }

        static void SortArrayFromIndexAscending(int[] arrOfNumbers, int startIndex)
        {
            Array.Sort(arrOfNumbers, startIndex, arrOfNumbers.Length - startIndex);
        }

        static void PrintArray(int[] arrOfNumbers)
        {
            foreach (int num in arrOfNumbers)
            {
                Console.Write("{0}  ", num);
            }
            Console.WriteLine();
        }
    }
}
