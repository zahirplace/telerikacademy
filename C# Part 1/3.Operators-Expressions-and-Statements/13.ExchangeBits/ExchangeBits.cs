using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            /*
             13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
            */

            Console.WriteLine("Write a number [>= 0]: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Binary number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

            number = ExchangeBitAtPosition(number, 3, 24);
            number = ExchangeBitAtPosition(number, 4, 25);
            number = ExchangeBitAtPosition(number, 5, 26);

            Console.WriteLine("The new number is: {0}", number);
            Console.WriteLine("Binary number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        }

        static uint ExchangeBitAtPosition(uint number, int bitPosition1, int bitPosition2)
        {
            uint bitVal1 = GetBitAtPosition(number, bitPosition1);
            uint bitVal2 = GetBitAtPosition(number, bitPosition2);

            if (bitVal1 != bitVal2)
            {
                number = (uint)(number ^ (1 << bitPosition1));
                number = (uint)(number ^ (1 << bitPosition2));
            }
            return number;
        }

        static uint GetBitAtPosition(uint number, int bitPosition)
        {
            uint bitMask = (uint)1 << bitPosition;
            uint setMask = number & bitMask;
            return setMask >> bitPosition;
        }

    }
}
