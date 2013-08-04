using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetBitAtPos
{
    class SetBitAtPos
    {
        static void Main(string[] args)
        {
            /*
             12. We are given integer number n, value v (v=0 or 1) and a position p. 
             Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	                    Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	                             n = 5 (00000101), p=2, v=0 -> 1 (00000001)
            */

            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a bit position: ");
            int bitPosition = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the value of the bit to be set: ");
            int bitValue = int.Parse(Console.ReadLine());

            int bitMask;
            int setMask;

            if (bitValue == 0)
            {
                bitMask = ~(1 << bitPosition);
                setMask = number & bitMask;
            }
            else
            {
                bitMask = (1 << bitPosition);
                setMask = number | bitMask;
            }

            Console.WriteLine("Binary number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("The new number is {0}", setMask);
            Console.WriteLine("Binary number: {0}", Convert.ToString(setMask, 2).PadLeft(32, '0'));

        }
    }
}
