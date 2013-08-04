using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EuclideanAlgorithm
{
    static void Main(string[] args)
    {
        /*
         8. Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
            Use the Euclidean algorithm (find it in Internet).
        */


        Console.Write("Number 1 = ");
        int numOne = int.Parse(Console.ReadLine());
        Console.Write("Number 2 = ");
        int numTwo = int.Parse(Console.ReadLine());

        int tempNum;

        while (numTwo != 0)
        {
            tempNum = numTwo;
            numTwo = numOne % numTwo;
            numOne = tempNum;
        }

        Console.WriteLine("The greatest common divisor (GCD) is {0}!", numOne);
    }
}

