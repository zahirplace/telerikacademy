using System;
using System.Linq;

class PrintCircleData
{
    static void Main(string[] args)
    {
        /*
         2. Write a program that reads the radius r of a circle and prints its perimeter and area.
        */

        Console.Write("Write the radius r of the circle: ");
        int radius = int.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter and the area of the circle are respectively:\n{0}\nand\n{1}!",
                            2 * Math.PI * radius,
                            Math.PI * Math.Pow(radius, 2)
                         );

    }
}
