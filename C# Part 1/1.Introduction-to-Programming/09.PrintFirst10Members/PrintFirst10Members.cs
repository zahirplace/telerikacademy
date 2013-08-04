using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirst10Members
{
    class PrintFirst10Members
    {
        static void Main(string[] args)
        {
            //9. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

            for (int i = 2; i <= 11; i++)
            {
                Console.Write("{0} ", Math.Pow((-1),i)*i);
            }
            Console.WriteLine();

        }
    }
}
