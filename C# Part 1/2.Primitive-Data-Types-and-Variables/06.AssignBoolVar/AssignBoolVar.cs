using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignBoolVar
{
    class AssignBoolVar
    {
        static void Main(string[] args)
        {
            /*
             6. Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.
            */

            bool isFemale;

            Console.WriteLine("Male/Female?:");
            string gender = Console.ReadLine().ToLower();

            if (gender == "female")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }

            int result = string.Compare("female", gender, true); //Not Case sensetive

            Console.WriteLine(isFemale);
            Console.WriteLine(result);
        }
    }
}
