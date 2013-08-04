using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class TrailingZeros
{
    static void Main(string[] args)
    {
        /*
         13. * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
                Examples:
                N = 10 -> N! = 3628800 -> 2
                N = 20 -> N! = 2432902008176640000 -> 4
              Does your program work for N = 50 000?
              Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
        */

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger zeroCounter = 0;

        for (int i = 5; i <= n; i *= 5)
        {
            zeroCounter += n / i;
        }

        Console.WriteLine("The trailing zeros at the end of the number {0}! are {1}.", n, zeroCounter);
    }
}
