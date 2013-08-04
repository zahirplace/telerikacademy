using System;
using System.Collections.Generic;
//using System.Numerics;
using System.Linq;
using System.Text;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            /*10. Write a program to calculate n! for each n in the range [1..100]. 
             Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.  
             */

            //Console.WriteLine("Integrals of all numbers to: ");
            //int number = int.Parse(Console.ReadLine());

            int number = 100;
            Console.WriteLine();

            double numFactorial = FindAndPrintFactorial(number);
            Console.WriteLine();
            Console.WriteLine("Factorial for {0} is {1}.", number, numFactorial);
            Console.WriteLine();
        }

        static double FindAndPrintFactorial(int Number)
        {
            double numFactorial;

            if (Number == 0)
            {
                PrintArray(Number, 1);
                return 1;
            }
            else
            {
                numFactorial = Number * FindAndPrintFactorial(Number - 1);
                PrintArray(Number, numFactorial);
                return numFactorial;
            }
        }

        public static void PrintArray(int num, double numFactorial)
        {
            Console.WriteLine("{0}!= {1}", num, numFactorial);
        }

    }
}
