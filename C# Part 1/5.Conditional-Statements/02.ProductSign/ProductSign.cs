using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSign
{
    class _ProductSign
    {
        static void Main(string[] args)
        {
            /*
             2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
                Use a sequence of if statements.
            */


            Console.WriteLine("Number one:");
            float numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            float numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            float numberThree = int.Parse(Console.ReadLine());

            //int negativeNumCount = 0;
            int? negativeNumCount = 0;

            float[] numberArray = { numberOne, numberTwo, numberThree };

            foreach (int num in numberArray)
            {
                if (num == 0)
                {
                    negativeNumCount = null;
                    break;
                }
                if (num < 0)
                {
                    negativeNumCount++;
                }
            }

            if (negativeNumCount == null)
            {
                Console.WriteLine("The Product of the numbers is 0!");
            }
            else
            {
                if (negativeNumCount % 2 == 0)
                {
                    Console.WriteLine("The Product of the numbers is positive!");
                }
                else
                {
                    Console.WriteLine("The Product of the numbers is negative!");
                }
            }

        }
    }
}
