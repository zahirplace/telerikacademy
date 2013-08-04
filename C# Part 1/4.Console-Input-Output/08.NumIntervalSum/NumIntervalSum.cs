using System;
using System.Linq;

class NumIntervalSum
{
    static void Main(string[] args)
    {
        /*
         8. Write a program that reads an integer number n from the console and
            prints all the numbers in the interval [1..n], each on a single line.
        */

        Console.Write("Enter number count n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("The numbers are: ");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
}
