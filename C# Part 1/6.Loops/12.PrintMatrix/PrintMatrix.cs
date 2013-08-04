using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintMatrix
{
    static void Main(string[] args)
    {
        /*
         12. Write a program that reads from the console a positive integer number N (N < 20) and 
             outputs a matrix like the following:
                N = 3			N = 4
        */

        Console.Write("N (0<N<20) = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int row = 1; row <= n; row++)
        {
            for (int column = row; column <= row + n - 1; column++)
            {
                Console.Write("{0} ", column);
            }
            Console.WriteLine();
        }
    }
}
