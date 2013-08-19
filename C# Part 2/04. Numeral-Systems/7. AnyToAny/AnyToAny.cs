using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnyToAny
{
    class AnyToAny
    {
        static void Main(string[] args)
        {
            //07. Write a program to convert from any numeral system of given base s to any other numeral system 
            //of base d (2 ≤ s, d ≤  16). 


            Hashtable hexNumbers = new Hashtable();
            hexNumbers.Add("A", 10);
            hexNumbers.Add("B", 11);
            hexNumbers.Add("C", 12);
            hexNumbers.Add("D", 13);
            hexNumbers.Add("E", 14);
            hexNumbers.Add("F", 15);
            hexNumbers.Add(10, "A");
            hexNumbers.Add(11, "B");
            hexNumbers.Add(12, "C");
            hexNumbers.Add(13, "D");
            hexNumbers.Add(14, "E");
            hexNumbers.Add(15, "F");


            Console.Write("Insert a number: ");
            string number = Console.ReadLine();

            Console.Write("Convert from system of base: ");
            int baseFrom = int.Parse(Console.ReadLine());

            Console.Write("Convert to system of base: ");
            int baseTo = int.Parse(Console.ReadLine());

            int decNumber = AnyToDecimal(number, baseFrom, hexNumbers);
            Console.WriteLine(DecimalToAny(decNumber, baseTo, hexNumbers));
        }

        static int AnyToDecimal(string AnyNumber, int sysBase, Hashtable hexNumbers)
        {
            if (sysBase == 10)
            {
                return int.Parse(AnyNumber);
            }

            int decNumber = 0;
            int digit = 0;
            try
            {
                for (int i = AnyNumber.Length - 1; i >= 0; i--)
                {
                    if (hexNumbers.Contains(AnyNumber[i].ToString()))
                    {
                        digit = (int)hexNumbers[AnyNumber[i].ToString()];
                    }
                    else
                    {                        
                        digit = int.Parse(AnyNumber[i].ToString());
                    }
                    if (digit != 0)
                    {
                        decNumber += (digit * (int)Math.Pow(16, (AnyNumber.Length - 1) - i));
                    }
                }
                return decNumber;
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }
        }

        static string DecimalToAny(int decNumber, int sysBase, Hashtable hexNumbers)
        {
            if (sysBase == 10)
            {
                return decNumber.ToString();
            }

            string binaryNumber = "";
            int rem = 0;
            try
            {
                while (decNumber > 0)
                {
                    rem = decNumber % sysBase;
                    decNumber /= sysBase;

                    if ((rem > 9) && hexNumbers.ContainsKey(rem))
                    {
                        binaryNumber = hexNumbers[rem] + binaryNumber;
                    }
                    else
                    {
                        binaryNumber = rem.ToString() + binaryNumber;
                    }
                }
                return binaryNumber;
            }
            catch
            {
                throw new FormatException("Invalid value!");
            }
        }

    }
}
