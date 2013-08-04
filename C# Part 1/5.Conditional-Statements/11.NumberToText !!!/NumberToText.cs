using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    class NumberToText
    {
        static void Main(string[] args)
        {
            /*
             11. Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. 
                 Examples:
	                  0 -> "Zero"
	                273 -> "Two hundred seventy three"
	                400 -> "Four hundred"
	                501 -> "Five hundred and one"
	                711 -> "Seven hundred and eleven"
            */


            Console.WriteLine("Insert a number in the range [0...999]: ");
            string tempNumber = Console.ReadLine();
            string number = tempNumber.TrimStart('0');
            switch (number.Length)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine(ReturnFor1(number)); break;
                case 2: Console.WriteLine(ReturnFor2(number)); break;
                case 3: Console.WriteLine(ReturnFor3(number)); break;
                default: Console.WriteLine("Invalid number!"); break;
            }
        }

        static string ReturnFor1(string number)
        {
            switch (number)
            {
                case "1": return "one";
                case "2": return "two";
                case "3": return "three";
                case "4": return "four";
                case "5": return "five";
                case "6": return "six";
                case "7": return "seven";
                case "8": return "eight";
                case "9": return "nine";
                default: return "Error";
            }
        }

        static string ReturnFor2(string Num)
        {
            string NumWithout0 = Num.TrimStart('0');
            if (NumWithout0.Length == 1)
            {
                return "and " + ReturnFor1(NumWithout0);
            }
            if (Num[1] == '0') { return ReturnForX0(Num); }
            switch (Num[0])
            {
                case '1': return ReturnFor1X(Num);
                default: return ReturnForX0(Num[0].ToString()) + " " + ReturnFor1(Num[1].ToString());
            }
        }
        static string ReturnFor3(string Num)
        {
            string Num23 = Num.Substring(1, 2);

            string andWord = ((Num[1] == '1') | (Num[2] == '0')) ? " and " : "";
            return (ReturnFor1(Num[0].ToString()) + " hundred " + andWord + ReturnFor2(Num23));
        }

        static string ReturnFor1X(string Num)
        {
            switch (Num[1])
            {
                case '0': return "ten";
                case '1': return "eleven";
                case '2': return "twelve";
                case '3': return "thirteen";
                default: return ReturnFor1(Num[1].ToString()) + "teen";
            }
        }
        static string ReturnForX0(string Num)
        {
            switch (Num[0])
            {
                case '1': return ReturnFor1X(Num);
                case '2': return "twenty";
                case '3': return "thirty";
                case '5': return "fifty";
                case '8': return ReturnFor1(Num[0].ToString()) + "y";
                default: return ReturnFor1(Num[0].ToString()) + "ty";
            }
        }

    }
}
