using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrintCurrentDateTime
{
    class PrintCurrentDateTime
    {
        static void Main(string[] args)
        {
            //7. Create a console application that prints the current date and time.

            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            DateTime dt = DateTime.Now;                      
            Console.WriteLine(dt);
        }
    }
}
