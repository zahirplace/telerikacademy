using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main(string[] args)
        {
            /*
              12. Find online more information about ASCII (American Standard Code for Information Interchange) and 
              write a program that prints the entire ASCII table of characters on the console.
            */

            Console.OutputEncoding = Encoding.ASCII;

            for (int symbolNum = 0; symbolNum <= 127; symbolNum++)
            {

                System.Console.WriteLine("{0} = {1}", symbolNum, (char)symbolNum);

            }

        }
    }
}
