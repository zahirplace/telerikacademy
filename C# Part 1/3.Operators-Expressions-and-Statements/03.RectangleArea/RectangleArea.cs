using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            /*
             3. Write an expression that calculates rectangle’s area by given width and height.
            */

            Console.WriteLine("Write rectangle’s width and height separated with a space: ");
            string[] number = Console.ReadLine().Split(' ');
            float width = int.Parse(number[0]);
            float height = int.Parse(number[1]);

            Console.WriteLine("The Rectangle’s area is: {0}", width*height);
        }
    }
}
