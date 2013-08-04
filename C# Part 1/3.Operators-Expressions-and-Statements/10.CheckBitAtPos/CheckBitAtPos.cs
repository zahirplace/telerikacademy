using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtPos
{
    class CheckBitAtPos
    {
        static void Main(string[] args)
        {
            /*
             10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
                    Example: v=5; p=1 -> false.
            */

            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a bit position: ");
            int bitPosition = int.Parse(Console.ReadLine());

            int bitMask = 1 << bitPosition;
            int setMask = number & bitMask;
            int bit = setMask >> bitPosition;

            Console.WriteLine("The bit {0} of the number {1} is {2}1!", bitPosition, number, bit == 1 ? "" : "NOT ");
            Console.WriteLine("Binary number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
