using System;
using System.Linq;

    class PrintNNumSum
    {
        static void Main(string[] args)
        {
            /*
             7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
            */

            Console.Write("Enter number count n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number {0}: ", i);
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", sum);

        }
    }
