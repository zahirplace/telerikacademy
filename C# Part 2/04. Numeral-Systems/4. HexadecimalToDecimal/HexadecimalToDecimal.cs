using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Globalization;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            //04. Write a program to convert hexadecimal numbers to their decimal representation.

            Hashtable hexNumbers = new Hashtable();
            hexNumbers.Add("A", 10);
            hexNumbers.Add("B", 11);
            hexNumbers.Add("C", 12);
            hexNumbers.Add("D", 13);
            hexNumbers.Add("E", 14);
            hexNumbers.Add("F", 15);

            Console.Write("Insert a hexadecimal number: ");

            try
            {
                string hexNumber = Console.ReadLine();
                int decNumber = HexadecimalToDecimalM(hexNumber, hexNumbers);
                Console.WriteLine(decNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static int HexadecimalToDecimalM(string hexNumber, Hashtable hexNumbers)
        {
            int decNumber = 0;
            int digit = 0;
            try
            {
                for (int i = hexNumber.Length - 1; i >= 0; i--)
                {
                    if (hexNumbers.Contains(hexNumber[i].ToString()))
                    {
                        digit = (int)hexNumbers[hexNumber[i].ToString()];
                    }
                    else
                    {
                        digit = int.Parse(hexNumber[i].ToString());
                    }
                    if (digit != 0)
                    {
                        decNumber += (digit * (int)Math.Pow(16, (hexNumber.Length - 1) - i));
                    }
                }
                return decNumber;
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }
        }
    }
}
