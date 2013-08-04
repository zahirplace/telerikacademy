using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint
{
    class CheckPoint
    {
        static void Main(string[] args)
        {
            /*
             6. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
            */

            Console.WriteLine("Write coordinates of point (x,y) separated with a comma: ");
            string[] number = Console.ReadLine().Split(',');
            int x = int.Parse(number[0]);
            int y = int.Parse(number[1]);

            Console.WriteLine("The point ({0}, {1}) is {2} the circle K(O, 5)", x, y, Math.Pow(x, 2) + Math.Pow(y, 2) <= 5 * 5 ? "within" : "without");
        }
    }
}
