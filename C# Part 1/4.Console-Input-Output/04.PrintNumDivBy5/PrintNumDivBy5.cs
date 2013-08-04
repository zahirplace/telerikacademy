using System;
using System.Linq;

class PrintNumDivBy5
{
    static void Main(string[] args)
    {
        /*
         4. Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
            such that the reminder of the division by 5 is 0 (inclusive). 
            Example: p(17,25) = 2.
        */


        //Enter both numbers
        Console.Write("Write the first positive number: ");
        int numOne = int.Parse(Console.ReadLine());

        Console.Write("Write the second positive number: ");
        int numTwo = int.Parse(Console.ReadLine());

        int numCount = 0;
        int divider = 5;

        if ((numOne > numTwo) || (numOne <= 0) || (numTwo <= 0))
        {
            Console.WriteLine("Incorrect numbers!");
        }
        else
        {
            // In case the numbers are equal
            if ((numOne == numTwo) && (numOne % divider == 0))
            {
                numCount++;
            }

            //Calculate numbers' count
            numCount = numCount + (numTwo / divider) - (numOne / divider);

            //Print the result
            Console.WriteLine("There are {0} numbers between numbers {1} and {2} (inclusive) which can be divided by {3} without a remainder!",
                                numCount, numOne, numTwo, divider);
        }



        // II way

        //uint a, b; // I use uint because we have positive integer numbers
        //Console.WriteLine("Please enter the first number: ");

        //while
        //(!uint.TryParse(Console.ReadLine(), out a))
        //{
        //    Console.Write("Invalid input. Try again please:");
        //}
        //Console.WriteLine("Please enter the second number:");

        //while
        //(!uint.TryParse(Console.ReadLine(), out b))
        //{
        //    Console.Write("Invalid input. Try again please:");
        //}

        //uint count = 0;
        //for (uint i = a; i <= b; i++)
        //{
        //    if (i % 5 == 0) //Checking if the current number can be divided by 5 without a remainder
        //    {
        //        count = count++; //If the condition is true - we increment the count of numbers between a and b, that the reminder of the division by 5 is 0, by 1.
        //    }
        //}
        //Console.WriteLine(count);


    }
}
