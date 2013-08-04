using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximalEqualElements
{
    class MaximalEqualElements
    {
        static void Main(string[] args)
        {
            /*
             Write a program that finds the maximal sequence of equal elements in an array.
		     Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
             */

            int[] IniArray1 = { 2, 1, 1, 2, 3, 3, 3, 3, 2, 2, 2, 1 };
            int Elem;
            int elemCount = MaxSeq(IniArray1, out Elem);

            Console.Write("The Maximal sequence (or one such sequence) of equal elements is: ");
            for (int i = 0; i < elemCount; i++)
            {
                Console.Write("{0} ", Elem);
            }
            Console.WriteLine();
        }

        static int MaxSeq(int[] IntArray, out int maxSeqElement)
        {
            int counter = 1;
            int maxCount = 1;
            maxSeqElement = IntArray[0];
            for (int i = 0; i < IntArray.Length - 1; i++)
            {
                if (IntArray[i] == IntArray[i + 1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        maxSeqElement = IntArray[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            return maxCount;
        }
    }
}
