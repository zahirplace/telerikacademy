using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximalSumSequence
{
    class MaximalSumSequence
    {
        static void Main(string[] args)
        {
            /*
             Write a program that finds the sequence of maximal sum in given array. Example:
	            {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}    	   
             */

           
            int[] IntArray1 = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8, 9 };
            
            int maxInd;
            int maxCounter;
            int maxSum;
            SequenceOfMaximalSum(IntArray1, out maxInd, out maxCounter, out maxSum);
            int IndFrom = maxInd;
            int IndTo = (maxInd + maxCounter);

            WriteIntArr(IntArray1, maxSum, IndFrom, IndTo);

        }

        static void SequenceOfMaximalSum(int[] arr, out int maxInd, out int maxCounter, out int maxSum)
        {            
            maxInd = 0;
            
            int sum = 0;
            maxSum = 0;
            int maxSumCurr = 0;

            int counter = 1;
            maxCounter = 0;
            int maxCounterCurr = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {                
                sum = arr[i];
                maxSumCurr = arr[i];
                counter = 1;
                maxCounterCurr = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    counter++;                    
                    if ((sum < (sum+arr[j])) && (maxSumCurr < (sum+arr[j])))
                    {
                        maxSumCurr = sum + arr[j];
                        maxCounterCurr = counter;         
                    }                    
                    sum += arr[j];                    
                }

                if (maxSum < maxSumCurr)
                {
                    maxSum = maxSumCurr;
                    maxCounter = maxCounterCurr;
                    maxInd = i;
                }
            }
        }

        static void WriteIntArr(int[] IntArr, int maxSum, int IndFrom, int IndTo)
        {
            Console.WriteLine("The sequence of maximal sum (Sum = {0}) in the array: ", maxSum);
            for (int i = IndFrom; i < IndTo; i++)
            {
                Console.Write("{0} ", IntArr[i]);
            }
            Console.WriteLine();
        }
    }
}
