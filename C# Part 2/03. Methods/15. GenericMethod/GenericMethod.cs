using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethod
{
    class GenericMethod
    {
        static void Main(string[] args)
        {
            /*15(*). Modify your last program and try to make it work for any number type, not just integer 
             (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
              */

            Console.WriteLine("Minimum number: {0}", GetMinimumNumber(9, 6, 5, 33, 7, 8));
            Console.WriteLine("Maximum number: {0}", GetMaximumNumber(6.5, 4.3, 2, 66.2));
            Console.WriteLine("Avarage: {0}", GetAvarage(5, 10, 150));
            Console.WriteLine("Sum: {0}", GetSum(12, 4));
            Console.WriteLine("Product: {0}", GetProduct(2, 5, -6, 3));
        }

        static T GetMinimumNumber<T>(params T[] numberArray)
        {
            return numberArray.Min();
        }

        static T GetMaximumNumber<T>(params T[] numberArray)
        {
            return numberArray.Max();
        }

        static T GetAvarage<T>(params T[] numberArray)
        {
            dynamic sum = 0;
            foreach (T num in numberArray)
            {
                sum += num;
            }

            return (sum / numberArray.Length);
        }

        static T GetSum<T>(params T[] numberArray)
        {
            dynamic sum = 0;
            foreach (T num in numberArray)
            {
                sum += num;
            }

            return sum;
        }

        static T GetProduct<T>(params T[] numberArray)
        {
            dynamic product = 1;
            foreach (T num in numberArray)
            {
                product *= num;
            }

            return product;
        }

    }
}
