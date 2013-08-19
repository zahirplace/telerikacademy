using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Short_16bitSigned_AsBinary
{
    class Short_16bitSigned_AsBinary
    {
        static void Main(string[] args)
        {
            //08. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

            Console.Write("Insert a 16-bit signed integer (short type) number: ");
            short shortNum = Convert.ToInt16(Console.ReadLine());

            byte lowByte = (byte)(shortNum & 0xff);
            byte highByte = (byte)((shortNum >> 8) & 0xff);

            Console.WriteLine("{0}{1}", Convert.ToString(highByte, 2), Convert.ToString(lowByte, 2));
        }
    }
}
