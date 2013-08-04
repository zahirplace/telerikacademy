using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            /*
             Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
             Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
             */

            int[] IniArray1 = { 2, 5, 3, 6, 1, 8, 4, 7 };

            SelectionSortM(IniArray1);
            WriteIntArr(IniArray1);

        }

        static void SelectionSortM(int[] Arr)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
                for (int j = i + 1; j < Arr.Length; j++)
                    if (Arr[i] > Arr[j])
                    {
                        Exchange(i, j, Arr);
                    }
        }

        static void Exchange(int elem, int smallest, int[] arr)
        {
            int temp1 = arr[elem];
            arr[elem] = arr[smallest];
            arr[smallest] = temp1;
        }

        static void WriteIntArr(int[] IntArr)
        {
            for (int i = 0; i < IntArr.Length; i++)
            {
                Console.Write("{0} ", IntArr[i]);
            }
            Console.WriteLine();
        }

    }
}
