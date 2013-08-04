using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignQuotedStr
{
    class AssignQuotedStr
    {
        static void Main(string[] args)
        {
            /*
             8. Declare two string variables and assign them with following value:
                    The "use" of quotations causes difficulties.
           	 Do the above in two different ways: with and without using quoted strings.
            */

            string strVariable1 = "The \"use\" of quotations causes difficulties.";
            string strVariable2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("String variable 1: {0}\nString variable 2: {1}", strVariable1, strVariable2);
        }
    }
}
