using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Hello
    {
        static void Main(string[] args)
        {
            /*
             1. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
             Write a program to test this method.
             */

            Console.WriteLine("Your name:");
            string name = Console.ReadLine();
            HelloM(name);
        }

        static void HelloM(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
