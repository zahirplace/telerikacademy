using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDescending
{
    class SortDescending
    {
        static void Main(string[] args)
        {
            /*
             4. Sort 3 real values in descending order using nested if statements.
            */


            Console.WriteLine("Number one:");
            float numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            float numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            float numberThree = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine("{0}, {1}, {2}", numberOne, numberTwo, numberThree);
                }
                else
                {
                    if (numberOne > numberThree)
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberOne, numberThree, numberTwo);
                    }
                    else
                        Console.WriteLine("{0}, {1}, {2}", numberThree, numberOne, numberTwo);
                }
            }
            else
            {
                if (numberThree > numberTwo)
                {
                    Console.WriteLine("{0}, {1}, {2}", numberThree, numberTwo, numberOne);
                }
                else
                {
                    if (numberOne > numberThree)
                    {
                        Console.WriteLine("{0}, {1}, {2}", numberTwo, numberOne, numberThree);
                    }
                    else
                        Console.WriteLine("{0}, {1}, {2}", numberTwo, numberThree, numberOne);

                }
            }
        }
    }
}
