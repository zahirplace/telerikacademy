using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckThirdBit
{
    class CheckThirdBit
    {
        static void Main(string[] args)
        {
            /*
             5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
             */

            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            int bitNumber = 3;
            int bitMask = 1 << bitNumber;
            int setMask = number & bitMask;
            int bit = setMask >> bitNumber;

            Console.WriteLine("The bit 3 of the number {0} is {1}!", number, bit);
        }
    }
}
