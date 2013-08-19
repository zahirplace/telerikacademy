using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            //01. Write a program to convert decimal numbers to their binary representation.

            Console.Write("Insert a decimal number: ");

            try
            {
                int decNumber = int.Parse(Console.ReadLine());

                Stack binaryNumber = DecimalToBinaryM(decNumber);
                WriteDecimalNumber(binaryNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static Stack DecimalToBinaryM(int decNumber)
        {
            Stack binaryNumber = new Stack();
            int rem = 0;
            try
            {
                while (decNumber > 0)                
                {

                    rem = decNumber % 2;
                    decNumber /= 2;
                    binaryNumber.Push(rem);
                }

                return binaryNumber;
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }

        }

        static void WriteDecimalNumber(Stack Number)
        {
            while (Number.Count > 0)
            {
                Console.Write(Number.Pop());
            }
            Console.WriteLine();
        }

    }
}
