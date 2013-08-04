using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FibonacciNSum
{
    static void Main(string[] args)
    {
        /*
         7. Write a program that reads a number N and calculates the sum of the first N members 
            of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

        */

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int firstNum = 0;
        int secondNum = 1;
        int tempNum = 0;
        int sum = firstNum + secondNum;

        for (int i = 3; i <= n; i++)
        {
            tempNum = secondNum;
            secondNum += firstNum;
            sum += secondNum;
            firstNum = tempNum;
        }

        Console.WriteLine("Sum = {0}", sum);
    }
}
