using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignSymbToChar
{
    class AssignSymbToChar
    {
        static void Main(string[] args)
        {
            /* 
             5. Declare a character variable and assign it with the symbol that has Unicode code 72. 
             Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
            */

            char symbolChar = '\u0048';
            char symbolChar2 = (char)0x48;

            Console.WriteLine(symbolChar + " " + symbolChar2); // H
        }
    }
}
