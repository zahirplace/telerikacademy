using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] CharArr1 = { 'a', 'b', 'D', 'd' };
            char[] CharArr2 = { 'a', 'b', 'c', 'd' };

            string Str1 = new string(CharArr1);
            string Str2 = new string(CharArr2);

            int result = Str1.CompareTo(Str2);

            switch (result)
            {
                case 0: Console.WriteLine("The strings are equal."); break;
                case -1: Console.WriteLine("StrArray1 is before StrArray2."); break;
                case 1: Console.WriteLine("StrArray1 is after StrArray2."); break;
                default: Console.WriteLine("Error!"); break;
            }
        }
    }
}
