using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            /*
             1. Write an expression that checks if given integer is odd or even.
            */

            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());            
            string ifEvenStr = (number % 2) == 0 ? "The number is even!" : "The number is odd!";
            Console.WriteLine(ifEvenStr);

        }
    }
}
