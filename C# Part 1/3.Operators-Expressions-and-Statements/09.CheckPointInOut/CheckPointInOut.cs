using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointInOut
{
    class CheckPointInOut
    {
        static void Main(string[] args)
        {
            /*
             9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and 
             out of the rectangle R(top=1, left=-1, width=6, height=2).
            */

            Console.WriteLine("Write coordinates of point (x,y) separated with a comma: ");
            string[] number = Console.ReadLine().Split(',');
            int x = int.Parse(number[0]);
            int y = int.Parse(number[1]);
            
            bool isWithinCircle = Math.Sqrt(Math.Pow(1 - x, 2) + Math.Pow(1 - y, 2)) <= 3;
            bool isOutOfRectangle = (x < -1 || x > (-1 + 6)) || (y > 1 || y < (1 - 2));

            Console.WriteLine("The point ({0}, {1}) is {2}within the circle K((1,1),3) and out of the rectangle R(top=1, left=-1, width=6, height=2) at the same time!",
                                x, y, isWithinCircle && isOutOfRectangle ? "" : "NOT ");

        }
    }
}
