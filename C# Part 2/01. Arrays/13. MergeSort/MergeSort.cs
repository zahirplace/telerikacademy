using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            /*
             (*) Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
             */

            int[] IniArray1 = { 4, 3, 1, 7, 2, 5, 8 };
            WriteIntArr(IniArray1);
            Console.WriteLine();
            int minInd = 0;
            int maxInd = IniArray1.Length - 1;
            MergeSortM(ref IniArray1, minInd, maxInd);
            WriteIntArr(IniArray1);
        }

        static void WriteIntArr(int[] IntArr)
        {
            for (int i = 0; i < IntArr.Length; i++)
            {
                Console.Write("{0} ", IntArr[i]);
            }
        }

        static void MergeSortM(ref int[] Arr, int Low, int High)
        {
            int mid;
            if (Low < High)
            {
                mid = (Low + High) / 2;
                MergeSortM(ref Arr, Low, mid);
                MergeSortM(ref Arr, mid + 1, High);
                Merge(ref Arr, Low, mid, High);
            }
        }

        static void Merge(ref int[] Arr, int low, int high1, int high2)
        {
            int[] tempArr = new int[Arr.Length];
            int ind = low;
            int lowInd = low;
            int UpInd = high1 + 1;

            while ((lowInd <= high1) && (UpInd <= high2))
            {
                if (Arr[lowInd] <= Arr[UpInd])
                {
                    tempArr[ind] = Arr[lowInd];
                    lowInd++;
                }
                else
                {
                    tempArr[ind] = Arr[UpInd];
                    UpInd++;
                }
                ind++;
            }


            if (lowInd <= high1)
            {
                while (lowInd <= high1)
                {
                    tempArr[ind] = Arr[lowInd];
                    lowInd++;
                    ind++;
                }
            }
            else
            {
                while (UpInd <= high2)
                {
                    tempArr[ind] = Arr[UpInd];
                    UpInd++;
                    ind++;
                }
            }
            for (ind = low; ind <= high2; ind++)
            {
                Arr[ind] = tempArr[ind];
            }
        }

    }
}
