using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            /*
             3. Write a program that finds the biggest of three integers using nested if statements.
            */

            Console.WriteLine("Number one:");
            float numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            float numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            float numberThree = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                if (numberOne > numberThree)
                {
                    Console.WriteLine("Max number: {0}", numberOne);
                }
                else
                    Console.WriteLine("Max number: {0}", numberThree);
            }
            else
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine("Max number: {0}", numberTwo);
                }
                else
                    Console.WriteLine("Max number: {0}", numberThree);
            }
        }
    }
}
