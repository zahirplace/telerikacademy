using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllocateAndInitialize
{
    class AllocateAndInitialize
    {
        static void Main(string[] args)
        {
            /*
             Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
             Print the obtained array on the console.
             */

            
            int[] IniArrary = new int[20];
            for (int i = 0; i < IniArrary.Length; i++)
            {
                IniArrary[i] = i * 5;
                Console.WriteLine("Element {0}: {1}", i,IniArrary[i]);
            }            
		    
        }
    }
}
