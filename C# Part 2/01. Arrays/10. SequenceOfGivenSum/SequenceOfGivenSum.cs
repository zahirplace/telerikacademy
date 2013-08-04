using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main(string[] args)
        {
            /*
             Write a program that finds in given array of integers a sequence of given sum S (if present). 
             Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
             */            

            //int[] IniArray1 = { 4, 2, 2, 3, 2, 5, 8 }; //-> {2, 2, 3}
            //int fixedSum = 7;

            int[] IniArray1 = { 4, 3, 1, 4, 2, 5, 8 }; //-> {4, 2, 5}
            int fixedSum =11;

            int firstInd;
            int counter;
            
            FindSequenceOfSum(IniArray1, fixedSum, out firstInd, out counter);
            WriteIntArr(IniArray1, fixedSum, firstInd, (firstInd + counter));

        }
        
        static void FindSequenceOfSum(int[] arr, int fixedSum, out int firstInd, out int maxCounter)
        {
            firstInd = 0;            
            int sum = 0;            
            int SumCurr = 0;
            int counter = 1;
            maxCounter = 0;            

            for (int i = 0; i < arr.Length - 1; i++)            
            {
                sum = arr[i];
                SumCurr = arr[i];
                counter = 1;
                
                for (int j = i + 1; j < arr.Length; j++)                
                {
                    counter++;

                    if (fixedSum < (sum + arr[j]))
                    {
                        break;
                    }

                    if (fixedSum == (sum + arr[j]))
                    {
                        SumCurr = sum + arr[j];
                        maxCounter = counter;
                        firstInd = i;
                        break;
                    }
                    else
                    {                       
                        sum += arr[j];                       
                    }                   
                }
                if (fixedSum == SumCurr)
                {
                    break;
                }               
            }
        }

        static void WriteIntArr(int[] IntArr, int maxSum, int IndFrom, int IndTo)
        {
            Console.WriteLine("Sequence of given sum (Sum = {0}) in the array: ", maxSum);
            for (int i = IndFrom; i < IndTo; i++)
            {
                Console.Write("{0} ", IntArr[i]);
            }
            Console.WriteLine();
        }

    }
}
