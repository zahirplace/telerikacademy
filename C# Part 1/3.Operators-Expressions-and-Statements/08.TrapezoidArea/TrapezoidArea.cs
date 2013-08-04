using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            /*
             8. Write an expression that calculates trapezoid's area by given sides a and b and height h.
            */

            Console.WriteLine("Write  trapezoid's sides a and b and height h, separated with a space: ");
            string[] number = Console.ReadLine().Split(' ');
            float a = int.Parse(number[0]);
            float b = int.Parse(number[1]);
            float h = int.Parse(number[2]);

            Console.WriteLine("The Rectangle’s area is: {0}", ((a + b) * h) / 2);
        }
    }
}
