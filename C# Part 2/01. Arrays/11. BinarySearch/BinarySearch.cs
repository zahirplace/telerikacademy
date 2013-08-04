using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            /*
             Write a program that finds the index of given element in a sorted array of integers by using 
             the Binary search algorithm (find it in Wikipedia).
            */

            int[] IniArray1 = { 2, 3, 11, 14, 18, 51, 64, 88 };
            Array.Sort(IniArray1);
            int SearchElem = 64;

            int minInd = 0;
            int maxInd = IniArray1.Length - 1;

            int ind = BinarySearchM(IniArray1, SearchElem, minInd, maxInd);

            if (ind != -1)
            {
                Console.WriteLine("Number {0} is found in the array with index = {1}.", SearchElem, ind);
            }
            else
            {
                Console.WriteLine("Number {0} is not found!", SearchElem);
            }

        }

        static int BinarySearchM(int[] IniArr, int sElem, int minInd, int maxInd)
        {
            int midInd = (minInd + maxInd) / 2;    

            if (midInd <= minInd)
            {
                return -1;
            }            
        
            if (sElem == IniArr[midInd])
            {
                return midInd;
            }
            else 
            {
                if (sElem < IniArr[midInd])
                {
                   return BinarySearchM(IniArr, sElem, minInd, midInd);
                }
                else
                {
                    return BinarySearchM(IniArr, sElem, midInd, maxInd);
                }
            }            
        }

    }
}
