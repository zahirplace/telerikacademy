using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchBitsAtPos
{
    class ExchBitsAtPos
    {
        static void Main(string[] args)
        {
            /*
             14. * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.
            */

            Console.Write("Write a number [>= 0]: ");
            uint number = uint.Parse(Console.ReadLine());

            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Binary number: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));   

            for (int i = 0; i < k; i++)
            {
                number = ExchangeBitAtPosition(number, p + i, q + i);
            }

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
