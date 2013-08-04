using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalcFacExpression
{
    static void Main(string[] args)
    {
        /*
         5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
        */

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K (K>N) = ");
        int k = int.Parse(Console.ReadLine());

        double factorialK = 1;
        for (int i = 1; i <= k; i++)
        {
            factorialK *= i;
        }

        double factorialN = 1;
        for (int i = k - n + 1; i <= n; i++)
        {
            factorialN *= i;
        }

        Console.WriteLine("Factorial = {0}", factorialK * factorialN);
    }
}

