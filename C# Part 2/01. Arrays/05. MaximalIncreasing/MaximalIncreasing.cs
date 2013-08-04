using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximalIncreasing
{
    class MaximalIncreasing
    {
        static void Main(string[] args)
        {
            /*
            Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
            */

            int[] IniArray1 = { 3, 2, 3, 4, 2, 2, 4, 8, 10, 3, 4, 5, 7, 8, 9, 4, 6, 7 };

            int maxIndex;
            int maxCount;

            MaxIncreasingSeq(IniArray1, out maxIndex, out maxCount);

            Console.WriteLine("The Maximal increasing sequence (or one such sequence) in the array is: ");
            for (int i = maxIndex; i <= (maxIndex + maxCount - 1); i++)
            {
                Console.Write("{0} ", IniArray1[i]);
            }
            Console.WriteLine();
        }

        static void MaxIncreasingSeq(int[] IntArray, out int maxIndex, out int maxCount)
        {
            int counter = 1;
            int index = 0;
            maxIndex = 0;
            maxCount = 1;

            for (int i = 0; i < IntArray.Length - 1; i++)
            {
                if (IntArray[i] < IntArray[i + 1])
                {
                    if (counter == 1)
                    {
                        index = i;
                    }
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        if (index > maxIndex)
                        {
                            maxIndex = index;
                        }
                    }
                }
                else
                {
                    counter = 1;
                }

            }
        }

    }
}
