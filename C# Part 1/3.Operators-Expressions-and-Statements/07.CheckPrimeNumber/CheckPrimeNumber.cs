using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrimeNumber
{
    class CheckPrimeNumber
    {
        static void Main(string[] args)
        {
            /*
             7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
            */

            Console.WriteLine("Write a positive integer number n (n ≤ 100): ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int divider = 2;

            while (divider <= Math.Sqrt(number))
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
                divider++;
            }

            Console.WriteLine("The number {0} is {1}prime!", number, isPrime ? "" : "NOT ");

        }
    }
}
