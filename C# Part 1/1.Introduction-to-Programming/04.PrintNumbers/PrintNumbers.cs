using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            //4. Write a program to print the numbers 1, 101 and 1001.

            int[] intList = new int[] { 1, 101, 1001 };

            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
