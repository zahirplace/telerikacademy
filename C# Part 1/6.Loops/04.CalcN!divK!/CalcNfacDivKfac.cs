using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalcNfacDivKfac
{
    static void Main(string[] args)
    {
        /*
         4. Write a program that calculates N!/K! for given N and K (1<K<N).
        */

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        double factorial = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial = {0}", factorial);
    }
}

