using System;
using System.Linq;

class PrintGreaterNumber
{
    static void Main(string[] args)
    {
        /*
         5. Write a program that gets two numbers from the console and prints the greater of them. 
            Don’t use if statements.
         */

        //Enter both numbers
        Console.Write("Write the first number: ");
        int numOne = int.Parse(Console.ReadLine());

        Console.Write("Write the second number: ");
        int numTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", Math.Max(numOne, numTwo));

    }
}
