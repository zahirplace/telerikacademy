using System;
using System.Linq;

class PrintNumberSum
{
    static void Main(string[] args)
    {
        /*
         1. Write a program that reads 3 integer numbers from the console and prints their sum.
        */

        Console.Write("Write number 1: ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int numTwo = int.Parse(Console.ReadLine());
        Console.Write("Write number 3: ");
        int numThree = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the numbers is: {0}", numOne + numTwo + numThree);
    }
}

