using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinSearch
{
    class BinSearch
    {
        static void Main(string[] args)
        {
            /*
             4. Write a program, that reads from the console an array of N integers and an integer K, 
             sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
             */

            int arrayLength;

            //check for correct (positive) length of the array
            while (true)
            {
                Console.WriteLine("Write a length of the array:");
                arrayLength = int.Parse(Console.ReadLine());
                if (arrayLength > 0)
                    break;
            }

            int[] array = new int[arrayLength];

            ReadArray(array, arrayLength);

            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            int searchedElementIndex = FindElementIndex(array, K);
            WriteResult(array, K, searchedElementIndex);
        }


        static int FindElementIndex(int[] array, int K)
        {
            Array.Sort(array);
            return Array.BinarySearch(array, K);
        }

        static void ReadArray(int[] array, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static void WriteResult(int[] array, int K, int searchedElementIndex)
        {
            Console.WriteLine();

            if (searchedElementIndex == -1)  //if K is smaller than all the elements in the array
            {
                Console.WriteLine("All elements are bigger than the searched one!");
            }
            else if (searchedElementIndex < 0) //if element K isn't found in the array
            {
                Console.WriteLine("The largest number in the array which is ≤ {0} is: {1}", K, array[~searchedElementIndex - 1]);
            }
            else //if there is element K in the array
                Console.WriteLine("The largest number in the array which is ≤ {0} is: {1}", K, array[searchedElementIndex]);

            Console.WriteLine();
        }

    }
}
