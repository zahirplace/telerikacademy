using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            /*
             1. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
            */


            Console.WriteLine("Number one:");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            int numberTwo = int.Parse(Console.ReadLine());
            int tempNumber;
            Console.WriteLine("You've inserted: Number one = {0}, Number two = {1}", numberOne, numberTwo);

            if (numberOne > numberTwo)
            {
                tempNumber = numberOne;
                numberOne = numberTwo;
                numberTwo = tempNumber;
            }
            Console.WriteLine("Result: Number one = {0}, Numbertwo = {1}", numberOne, numberTwo);
        }
    }
}
