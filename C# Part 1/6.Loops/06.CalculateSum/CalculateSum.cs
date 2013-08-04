using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSum
{
    static void Main(string[] args)
    {
        /*
         6. Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
        */

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / Math.Pow(x, i);
        }

        Console.WriteLine("The sum is {0}", sum);
    }
}

