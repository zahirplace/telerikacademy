using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSortAlgorithm
{
    class QuickSortAlgorithm
    {
        static void Main(string[] args)
        {

            /*
            Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
           */

                      
            string[] intArray = { "ooo", "ggg", "wwww", "rrrrr", "esrese", "bbbb", "aaa" };            

            WriteIntArr(intArray);            

            int maxInd = intArray.Length - 1;
            QuicksortM(intArray, 0, maxInd);

            WriteIntArr(intArray);            
        }
        
        static void QuicksortM(string[] intArray, int left, int right)
        {
            int i = left;
            int j = right;
            string tmp;
            
            string midElem = intArray[(left + right) / 2];
            while (i <= j)
            {                              
                while (String.Compare(intArray[i], midElem, false) == -1)
                {
                    i++;
                }
                
                while (String.Compare(midElem, intArray[j], false) == -1)
                {
                    j--;
                }
                if (i <= j)
                {                    
                    tmp = intArray[i];
                    intArray[i] = intArray[j];
                    intArray[j] = tmp;
                    i++;
                    j--;
                }
            }
            
            if (left < j)
            {
                QuicksortM(intArray, left, j);
            }
            if (i < right)
            {
                QuicksortM(intArray, i, right);
            }
        }

        static void WriteIntArr(string[] IntArr)
        {            
            for (int i = 0; i < IntArr.Length; i++)
            {
                Console.Write("{0} ", IntArr[i]);                
            }
            Console.WriteLine();
        }


    }
}
