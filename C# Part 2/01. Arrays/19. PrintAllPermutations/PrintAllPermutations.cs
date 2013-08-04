using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintAllPermutations
{
    class PrintAllPermutations
    {        
        static void Main(string[] args)
        {
            /*
             Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
             Example:
	            n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
             */

            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());            
            
            int[] loops = new int[N];

            ElemVariations(0, N, loops);

        }


        static void ElemVariations(int currentLoop, int N, int[] loops)
        {
            if (currentLoop == N)
            {
                PrintVariations(N, loops);
                return;
            }
            
            for (int counter = 1; counter <= N; counter++)
            {               
                loops[currentLoop] = counter;
                ElemVariations(currentLoop +1, N, loops);
            }
        }

        static void PrintVariations(int N, int[] loops)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }

    }
}
