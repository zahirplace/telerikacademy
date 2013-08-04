using System;
using System.Linq;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        /*
         6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and 
            solves it (prints its real roots).
         */


        Console.Write("Enter a coefficient a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter a coefficient b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter a coefficient c: ");
        int c = int.Parse(Console.ReadLine());

        //The Real Roots
        double x1, x2;

        double d = Math.Pow(b, 2) - 4 * a * c;

        if ((d >= 0) && (a != 0))
        {

            x1 = (-b + Math.Sqrt(d)) / (2 * a);

            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            if (d == 0)
            {
                Console.WriteLine("There is one Real Root:\n{0}", x1);
            }
            else
            {
                Console.WriteLine("There are two Real Roots:\n1) {0}\n2) {1}", x1, x2);
            }

        }
        else
            Console.WriteLine("There are NO Real Roots!");
    }

}
