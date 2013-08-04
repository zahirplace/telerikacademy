using System;
using System.Linq;

class PrintSumWithAccuracy
{
    static void Main(string[] args)
    {
        /*
         10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
        */

        double accuracy = 0.001;
        double sumNew = 1;
        double sumOld = 0;
        int divider = 2;

        while (Math.Abs(sumNew - sumOld) > accuracy)
        {
            sumOld = sumNew;
            sumNew += (1 / (divider * Math.Pow(-1, divider)));
            divider++;
        }

        Console.WriteLine("Sum = {0:f3}\nAccuracy = {1:f3}", sumNew, (sumNew - sumOld));
    }
}

