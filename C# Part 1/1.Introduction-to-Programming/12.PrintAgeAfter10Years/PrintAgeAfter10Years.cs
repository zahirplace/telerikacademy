using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAgeAfter10Years
{
    class PrintAgeAfter10Years
    {
        static void Main(string[] args)
        {
            /*12.* Write a program to read your age from the console and print how old you will be after 10 years.
                  /Използвайте методите System.Console.ReadLine(), int.Parse() и System.DateTime.AddYears()./
            */

            int yearCount = 10;

            Console.Write("Write your age: ");
            int myAge = int.Parse(Console.ReadLine());            

            DateTime currentDate = DateTime.Now;
            int birthYear = currentDate.Year - myAge;                                
            
            Console.WriteLine("After {0} years you'll be at {1}!", 
                               yearCount, DateTime.Now.AddYears(yearCount).Year - birthYear);
            
        }
    }
}
