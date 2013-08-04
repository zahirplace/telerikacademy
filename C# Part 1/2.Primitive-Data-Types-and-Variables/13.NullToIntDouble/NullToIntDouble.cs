using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullToIntDouble
{
    class NullToIntDouble
    {
        static void Main(string[] args)
        {
            /*
             13. Create a program that assigns null values to an integer and to double variables. 
             Try to print them on the console, try to add some values or the null literal to them and see the result.
            */

            int? intNullVar = null;
            double? doubleNullVar = null;
            Console.WriteLine("Int Null Variable: {0}\nDouble Null Variable: {1}", intNullVar, doubleNullVar);  //
            
            intNullVar += 5;
            doubleNullVar += 6;
            Console.WriteLine("Int Null Variable: {0}\nDouble Null Variable: {1}", intNullVar, doubleNullVar);  //

            intNullVar += null;
            doubleNullVar += null;
            Console.WriteLine("Int Null Variable: {0}\nDouble Null Variable: {1}", intNullVar, doubleNullVar);  //

            intNullVar = 5;
            doubleNullVar = 6;
            Console.WriteLine("Int Null Variable: {0}\nDouble Null Variable: {1}", intNullVar, doubleNullVar); // 5, 6


            intNullVar += null;
            doubleNullVar += null;
            Console.WriteLine("Int Null Variable: {0}\nDouble Null Variable: {1}", intNullVar, doubleNullVar);  //
        }
    }
}
