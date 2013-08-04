using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRem
{
    class DivideWithoutRemainder
    {
        static void Main(string[] args)
        {
            /*
             2. Write a boolean expression that checks for given integer if it can be divided (without remainder) 
             by 7 and 5 in the same time.
            */


            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            int[] numArray = {5,7};

            bool canBeDivided = true;
            foreach(int num in numArray)
            {
                if (number%num!=0)
                {
                    canBeDivided = false;
                    break;
                }
            }

            Console.WriteLine( "The number {0} can{1} be divided by 5 and 7 at the same time!", number, canBeDivided? "" : " NOT");

        }
    }
}
