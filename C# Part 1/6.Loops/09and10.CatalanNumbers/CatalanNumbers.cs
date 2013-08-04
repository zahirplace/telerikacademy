using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CatalanNumbers
{
    static void Main(string[] args)
    {
        /*
         9and10. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:...
                 Write a program to calculate the Nth Catalan number by given N.
             
         Cn = (2n)!/(n+1)!*n! ,  n>=0
             
        The first Catalan numbers for n = 0, 1, 2, 3, … are
            1, 1, 2, 5, 14, 42, 132, 429, 1430, 4862, 16796, 58786, 208012, 742900, 2674440, 9694845, 35357670, 129644790....
        */

        Console.Write("N (>=0) = ");
        int n = int.Parse(Console.ReadLine()) - 1;

        double factorialN = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }

        double factorialNPartial = 1;
        for (int i = n + 2; i <= 2 * n; i++)
        {
            factorialNPartial *= i;
        }

        Console.WriteLine("Factorial = {0}", factorialNPartial / factorialN);
    }
}
