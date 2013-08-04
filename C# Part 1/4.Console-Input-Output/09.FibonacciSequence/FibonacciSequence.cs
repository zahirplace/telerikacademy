using System;
using System.Linq;

class FibonacciSequence
{
    static void Main(string[] args)
    {
        /*
         9. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        */


        int numCount = 100;
        decimal a1 = 0;
        decimal a2 = 1;
        decimal a3 = 1;

        Console.WriteLine("{0}\n{1}\n{2}", a1, a2, a3);

        for (int i = 4; i <= numCount; i++)
        {
            a1 = a2;
            a2 = a3;
            a3 += a1;
            Console.WriteLine(a3);
        }
    }
}
