using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFloatNums
{
    class CompareFloatNums
    {
        static void Main(string[] args)
        {
            /* 
             3. Write a program that safely compares floating-point numbers with precision of 0.000001. 
             Examples:(5.3 ; 6.01) -> false;  
                       (5.00000001 ; 5.00000003) -> true
            */


            float numOne = 5.3f;
            float numTwo = 6.01f;

            float numThree = 5.00000001f;
            float numFour = 5.00000003f;

            bool equalNum1 = (numOne == numTwo);       
            bool equalNum2 = (numThree == numFour);
            
            Console.WriteLine("{0}\n{1}", equalNum1, equalNum2);    //False True

        }
    }
}
