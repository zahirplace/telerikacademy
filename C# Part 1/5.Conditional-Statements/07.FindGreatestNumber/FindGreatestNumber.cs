using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGreatestNumber
{
    class FindGreatestNumber
    {
        static void Main(string[] args)
        {
            /*
             7. Write a program that finds the greatest of given 5 variables.
            */

            int maxNumberIndex = 0;

            int[] numberArray = new int[5];//{ numberOne, numberTwo, numberThree, numberFour, numberFive };

            Console.WriteLine("Insert 5 numbers:");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("number {0} = ", i + 1);
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < numberArray.Length; i++)
            {
                if (numberArray[i] > numberArray[i - 1])
                {
                    maxNumberIndex = i;
                }
            }

            Console.WriteLine("The max number is: {0}", numberArray[maxNumberIndex]);
        }
    }
}

