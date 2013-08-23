using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NonNumberException
{
    class NonNumberException
    {
        static void Main(string[] args)
        {
            /*
             Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
             If an invalid number or non-number text is entered, the method should throw an exception. 
             Using this method write a program that enters 10 numbers                      
            */

            try
            {
                int start = 1;
                int end = 10;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("{0}", ReadNumber(start, end));
                }

            }
            catch (InvalidNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }

        static int ReadNumber(int start, int end)
        {
            Console.Write("Enter a number between {0} and {1}: ", start, end);
            string strNum = Console.ReadLine();
            int number;
            if (!int.TryParse(strNum, out number) || (int.Parse(strNum) < 0) || (number < start) || (number > end))
            {
                throw new InvalidNumberException("Invalid number or non-number text is entered!");
            }
            return number;

        }

        class InvalidNumberException : Exception
        {
            public InvalidNumberException()
            {
            }
            public InvalidNumberException(string message)
                : base(message)
            {
            }
        }
    }
}
