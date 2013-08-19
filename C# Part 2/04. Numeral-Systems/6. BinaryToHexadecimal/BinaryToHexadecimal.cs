using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BinaryToHexadecimal
{

    class BinaryToHexadecimal
    {


        static void Main(string[] args)
        {
            //06. Write a program to convert binary numbers to hexadecimal numbers.

            Hashtable hexNumbers = new Hashtable();
            hexNumbers.Add("1010", "A");
            hexNumbers.Add("1011", "B");
            hexNumbers.Add("1100", "C");
            hexNumbers.Add("1101", "D");
            hexNumbers.Add("1110", "E");
            hexNumbers.Add("1111", "F");

            Console.WriteLine("Please Enter a binary number");

            string myNumber = Console.ReadLine();
            Console.WriteLine("Number in Hex: {0}", BinToHex(myNumber, hexNumbers));

        }

        static string BinToHex(string myNumber, Hashtable hexNumbers)
        {
            int remainder = myNumber.Length % 4;
            if (remainder != 0)
            {
                myNumber = new string('0', 4 - remainder) + myNumber; // filling the string with '0'
            }

            string result = string.Empty;
            for (int i = 0; i < myNumber.Length; i += 4)
            {
                string currentElement = myNumber.Substring(i, 4); // we have 4 digits

                if (hexNumbers.ContainsKey(currentElement))
                {
                    result = result + hexNumbers[currentElement];
                }
                else
                {
                    result = result + BinaryToDecimalM(currentElement);
                }

            }
            return result;
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

    }
}
