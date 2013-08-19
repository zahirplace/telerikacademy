using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomValues
{
    class RandomValues
    {
        static void Main(string[] args)
        {
            /*
            02. Write a program that generates and prints to the console 10 random values in the range [100, 200].
            */

            int numCount = 10;           
            PrintRandomListOfNumbers(numCount);

        }

        static void PrintRandomListOfNumbers(int numCount)
        {
            Random random = new Random();
            for (int number = 1; number <= numCount; number++)
            {
                int randomNumber = random.Next(101) + 100;
                Console.WriteLine("{0} ", randomNumber);
            }
        }

    }
}
