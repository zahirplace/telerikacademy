using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignStringObj
{
    class AssignStringObj
    {
        static void Main(string[] args)
        {
            /* 
             7. Declare two string variables and assign them with “Hello” and “World”. 
             Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
             Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
            */

            string hello = "Hello";
            string world = "World";

            object objHelloWorld = hello + " " + world;

            string helloWorld1 = (string)objHelloWorld;
            string helloWorld2 = objHelloWorld.ToString();

            Console.WriteLine("Object variable: {0}!\nString variable 1: {1}!\nString variable 2: {1}!",
                                objHelloWorld, helloWorld1, helloWorld2);

        }
    }
}
