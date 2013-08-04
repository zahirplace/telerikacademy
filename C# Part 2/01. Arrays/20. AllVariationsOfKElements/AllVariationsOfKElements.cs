using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllVariationsOfKElements
{
    class AllVariationsOfKElements
    {
        static void Main(string[] args)
        {
            /*
             Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
             Example:   N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
            */

            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());

            int[] loops = new int[N];
            ElemVariations(0, N, K, loops);
        }

        static void ElemVariations(int currentLoop, int N, int K, int[] loops)
        {
            if (currentLoop == K)
            {
                PrintVariations(K, loops);
                return;
            }

            for (int counter = 1; counter <= N; counter++)
            {
                loops[currentLoop] = counter;
                ElemVariations(currentLoop + 1, N, K, loops);
            }
        }

        static void PrintVariations(int K, int[] loops)
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }

    }
}
