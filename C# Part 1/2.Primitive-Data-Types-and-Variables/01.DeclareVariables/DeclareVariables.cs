using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            /*
            1. Declare five variables choosing for each of them the most appropriate of the types 
            byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
            52130, -115, 4825932, 97, -10000.
            */

            ushort numOne = 52130;
            sbyte numTwo = -115;
            uint  numThree = 4825932;
            byte  numFour = 97;
            short numFive = -10000;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", numOne, numTwo, numThree, numFour, numFive);

        }
    }
}
