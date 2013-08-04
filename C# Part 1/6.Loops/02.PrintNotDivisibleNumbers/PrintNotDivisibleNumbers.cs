using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNotDivisibleNumbers
{
    static void Main(string[] args)
    {
        /*
         2. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
        */


        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) || (i % 7 == 0))
            {
                continue;
            }
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}

