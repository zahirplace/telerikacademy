using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitNumber
{
    class ExtractBitNumber
    {
        static void Main(string[] args)
        {
            /*
             11. Write an expression that extracts from a given integer i the value of a given bit number b. 
             Example: i=5; b=2 -> value=1.
            */

            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Write a bit position: ");
            int bitPosition = int.Parse(Console.ReadLine());

            int bitMask = 1 << bitPosition;
            int setMask = number & bitMask;
            int bit = setMask >> bitPosition;
            
            Console.WriteLine("The bit {0} of the number {1} is {2}!", bitPosition, number, bit);
            Console.WriteLine("Binary number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
