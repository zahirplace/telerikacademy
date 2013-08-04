using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            /*
             Write a program that finds the most frequent number in an array. Example:
	        {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times) 
             */

            //int[] IniArray1 = { 1, 3, 4, 4, 2, 3, 4, 4, 1, 2, 9, 3, 3, 3 }; //-> 3 (5 times)
            //int[] IniArray1 = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }; //-> 4 (5 times)
            int[] IniArray1 = { 4, 1, 1, 2, 2, 3, 1, 4, 1, 2, 4, 9, 3 }; //-> 1 (4 times)

            int Number;
            int Count;
            GetMostFrequentNumber(IniArray1, out Number, out Count);
            Console.WriteLine("{0} ({1} times)", Number, Count);
        }


        static void GetMostFrequentNumber(int[] arr, out int maxElem, out int maxElemCount)
        {
            maxElemCount = 1;
            maxElem = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                int tempMaxElem = arr[i];
                int counter = 1;
                for (int j = i + 1; j < arr.Length; j++)                
                {
                    if (arr[j] == tempMaxElem)
                    {
                        counter++;
                    }
                }
                if (counter > maxElemCount)
                {
                    maxElemCount = counter;
                    maxElem = arr[i];
                }
            }

        }
    }
}
