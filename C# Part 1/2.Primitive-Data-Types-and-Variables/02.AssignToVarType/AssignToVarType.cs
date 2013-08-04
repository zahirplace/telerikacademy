using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignToVarType
{
    class AssignToVarType
    {
        static void Main(string[] args)
        {
            /*
             2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
             34.567839023, 12.345, 8923.1234857, 3456.091?
             */

            double numOne = 34.567839023;
            float numTwo = 12.345f;
            double numThree = 8923.1234857;
            float numFour = 3456.091f;

            Console.WriteLine("{0}, {1}, {2}, {3}", numOne, numTwo, numThree, numFour);
        }
    }
}
