using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            //03. Write a program to convert decimal numbers to their hexadecimal representation.

            Console.Write("Insert a decimal number: ");

            try
            {
                int decNumber = int.Parse(Console.ReadLine());
                Stack binaryNumber = DecimalToHexadecimalM(decNumber);
                WriteHexadecimalNumber(binaryNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static Stack DecimalToHexadecimalM(int decNumber)
        {
            Stack binaryNumber = new Stack();
            int rem = 0;
            try
            {
                while (decNumber > 0)
                {

                    rem = decNumber % 16;
                    decNumber /= 16;
                    binaryNumber.Push(rem);
                }
                return binaryNumber;
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }

        }

        static void WriteHexadecimalNumber(Stack Number)
        {
            while (Number.Count > 0)
            {
                Console.Write("{0:X}", Number.Pop());
            }
            Console.WriteLine();
        }

    }
}
