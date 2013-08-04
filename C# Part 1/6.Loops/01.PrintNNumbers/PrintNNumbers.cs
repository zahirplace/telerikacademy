using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintNNumbers
{
    static void Main(string[] args)
    {
        /*
         1. Write a program that prints all the numbers from 1 to N.
        */

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
