using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintMinMaxNumber
{
    static void Main(string[] args)
    {
        /*
         3. Write a program that reads from the console a sequence of N integer numbers and 
            returns the minimal and maximal of them.
        */

        Console.WriteLine("N = ");
        int n = int.Parse(Console.ReadLine());
        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;
        int tmpNum;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("n[{0}] = ", i);
            tmpNum = int.Parse(Console.ReadLine());

            if (tmpNum > maxNumber)
            {
                maxNumber = tmpNum;
            }

            if (tmpNum < minNumber)
            {
                minNumber = tmpNum;
            }
        }

        Console.WriteLine("The minimal number is {0}\nThe maximal number is {1}.", minNumber, maxNumber);
    }
}
