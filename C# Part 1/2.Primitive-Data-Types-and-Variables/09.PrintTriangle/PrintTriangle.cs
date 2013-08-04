using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
        {
            /*
             9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
             Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.
            */

            char copyright = '\u00A9';
            int symbolCount = int.Parse(Console.ReadLine());

            //I triangle case
            //Console.WriteLine("{0}", copyright);
            //for (int i = 2; i < symbolCount; i++)
            //{
            //    Console.Write("{0}", copyright);
            //    for (int j = 2; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("{0} ", copyright);
            //}
            //Console.WriteLine(new string(copyright, symbolCount));

            // II triangle case            
            for (int row = 0; row < symbolCount; row++)
            {
                for (int col = 0; col < 2 * symbolCount; col++)
                {
                    if ((row + col < symbolCount - 1) || (col >= symbolCount + row))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(copyright);
                    }
                }
                Console.WriteLine();
            }

            // III case

            //Console.OutputEncoding = Encoding.Unicode;

            //char a = '\u00A9';
            //int copyRight = (char)a;

            //int number = 4;


            //for (int n = 0; n < number; n++)
            //{

            //    for (int i = 4; i > n; i--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2 * n - 1; j++)
            //    {

            //        Console.Write((char)a);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
