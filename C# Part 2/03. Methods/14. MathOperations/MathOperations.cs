using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            /* 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
             Use variable number of arguments.
             */

            //Console.WriteLine("Insert number count:");
            //int numCount = int.Parse(Console.ReadLine());
            //int[] numberArray = new int[numCount];
            //InitializeArray(numberArray, numCount);
            //Console.WriteLine("Minimum number: {0}", GetMinimumNumber(numberArray));
            //Console.WriteLine("Maximum number: {0}", GetMaximumNumber(numberArray));
            //Console.WriteLine("Avarage: {0}", GetAvarage(numberArray));
            //Console.WriteLine("Sum: {0}", GetSum(numberArray));
            //Console.WriteLine("Product: {0}", GetProduct(numberArray));

            Console.WriteLine("Minimum number: {0}", GetMinimumNumber(9, 6, 5, 33, 7));
            Console.WriteLine("Maximum number: {0}", GetMaximumNumber(6, 4, 2, 66));
            Console.WriteLine("Avarage: {0}", GetAvarage(5, 10, 15));
            Console.WriteLine("Sum: {0}", GetSum(12, 4));
            Console.WriteLine("Product: {0}", GetProduct(2, 5, 6, 3));
        }

        static void InitializeArray(int[] numberArray, int numCount)
        {
            for (int i = 0; i < numCount; i++)
            {
                Console.WriteLine("number {0}", i + 1);
                numberArray[i] = int.Parse(Console.ReadLine());
            }
        }

        static int GetMinimumNumber(params int[] numberArray)
        {
            return numberArray.Min();
        }

        static int GetMaximumNumber(params int[] numberArray)
        {
            return numberArray.Max();
        }

        static double GetAvarage(params int[] numberArray)
        {
            double sum = 0;
            foreach (int num in numberArray)
            {
                sum += num;
            }
            return (sum / numberArray.Length);
        }

        static double GetSum(params int[] numberArray)
        {
            double sum = 0;
            foreach (int num in numberArray)
            {
                sum += num;
            }
            return sum;
        }

        static double GetProduct(params int[] numberArray)
        {
            double product = 1;
            foreach (int num in numberArray)
            {
                product *= num;
            }
            return product;
        }

    }
}
