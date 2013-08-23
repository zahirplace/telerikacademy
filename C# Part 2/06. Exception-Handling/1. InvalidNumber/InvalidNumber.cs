using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            /*
             1. Write a program that reads an integer number and calculates and prints its square root. 
             If the number is invalid or negative, print "Invalid number". 
             In all cases finally print "Good bye". 
             Use try-catch-finally.
            */


            try
            {
                Console.Write("Enter a number: ");
                string strNum = Console.ReadLine();
                int intNum;
                if (!int.TryParse(strNum, out intNum) || int.Parse(strNum) < 0)
                {
                    throw new System.ArgumentOutOfRangeException("Invalid number");
                }
                Console.WriteLine("The square of {0} is {1}.", strNum, Math.Sqrt(intNum));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
