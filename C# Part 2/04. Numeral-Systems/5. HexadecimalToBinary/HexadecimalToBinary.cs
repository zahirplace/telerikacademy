using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            //05. Write a program to convert hexadecimal numbers to binary numbers.

            Hashtable hexNumbers = new Hashtable();
            hexNumbers.Add('A', 1010);
            hexNumbers.Add('B', 1011);
            hexNumbers.Add('C', 1100);
            hexNumbers.Add('D', 1101);
            hexNumbers.Add('E', 1110);
            hexNumbers.Add('F', 1111);

            Console.Write("Insert a hexadecimal number: ");

            try
            {
                string hexNumber = Console.ReadLine();
                string decNumber = HexadecimalToBinaryM(hexNumber, hexNumbers);

                Console.WriteLine(decNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static string HexadecimalToBinaryM(string hexNumber, Hashtable hexNumbers)
        {
            string binaryNumber = "";
            int digit = 0;

            try
            {
                for (int i = 0; i <= hexNumber.Length - 1; i++)
                {
                    if (hexNumbers.ContainsKey(hexNumber[i]))
                    {
                        digit = (int)hexNumbers[hexNumber[i]];
                        binaryNumber += hexNumbers[hexNumber[i]].ToString();
                    }
                    else
                    {
                        digit = int.Parse(hexNumber[i].ToString());
                        binaryNumber += DecimalToBinaryM(digit);
                    }
                }
                return binaryNumber;
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }

        }

        static string DecimalToBinaryM(int decNumber)
        {
            string binaryNumber = "";
            int rem = 0;
            try
            {
                while (decNumber > 0)
                {

                    rem = decNumber % 2;
                    decNumber /= 2;
                    binaryNumber = rem + binaryNumber;
                }

                return binaryNumber.PadLeft(4, '0');
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }

        }

        static string hex2binary(string hexvalue)
        {
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
            return binaryval;
        }
    }

}
