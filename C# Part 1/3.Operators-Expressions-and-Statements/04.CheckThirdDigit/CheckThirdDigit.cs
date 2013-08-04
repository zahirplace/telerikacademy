using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckThirdDigit
{
    class CheckThirdDigit
    {
        static void Main(string[] args)
        {
            /*
             4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.
            */

            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            bool isSeven = true;
            int reminder;

            for (int i = 1; i <= 3; i++)
            {
                reminder = number % 10;
                if ((i == 3) && (reminder != 7))
                {
                    isSeven = false;
                }
                number /= 10;
            }

            Console.WriteLine("The third digit (right-to-left) of the number is {0}a 7!", isSeven ? "" : "NOT ");
        }
    }
}
