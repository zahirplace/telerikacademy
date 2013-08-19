using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            //02. Write a program to convert binary numbers to their decimal representation.

            Console.Write("Insert a binary number: ");

            // I variant
            try
            {
                string binaryNumber = Console.ReadLine();
                int decNumber = BinaryToDecimalM(binaryNumber);
                Console.WriteLine(decNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // II variant
            //string binaryNumber = Console.ReadLine();
            //Console.WriteLine(ToDecimal(binaryNumber));
        }

        static int BinaryToDecimalM(string binaryNumber)
        {
            int decNumber = 0;
            int digit = 0;
            try
            {
                for (int i = binaryNumber.Length - 1; i >= 0; i--)
                {
                    digit = (int)Char.GetNumericValue(binaryNumber[i]);
                    if (digit != 0)
                    {
                        decNumber += (digit * (int)Math.Pow(2, (binaryNumber.Length - 1) - i));
                    }
                }
                return decNumber;
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }
        }


        // II variant
        static int ToDecimal(string bin)
        {
            long l = Convert.ToInt64(bin, 2);
            int i = (int)l;
            return i;
        }


    }
}
