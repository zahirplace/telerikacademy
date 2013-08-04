using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            //11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

            int firstNum = 5;
            int secondNum = 10;

            Console.WriteLine("{0}, {1}", firstNum, secondNum);

            firstNum += secondNum;
            secondNum = firstNum - secondNum;
            firstNum -= secondNum;

            Console.WriteLine("{0}, {1}", firstNum, secondNum);

            // II way - WISE !!!!!!!!!!!!!!!

            //int first = 5;
            //int second = 10;
            //Console.WriteLine("{0}/{1}", first, second);
            //first ^= second; //Just copy from Net
            //second ^= first;
            //first ^= second;
            //Console.WriteLine("{0}/{1}", first, second);
        }
    }
}
