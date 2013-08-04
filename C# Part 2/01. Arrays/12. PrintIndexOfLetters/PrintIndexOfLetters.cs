using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintIndexOfLetters
{
    class PrintIndexOfLetters
    {
        static void Main(string[] args)
        {
            /*
             Write a program that creates an array containing all letters from the alphabet (A-Z). 
             Read a word from the console and print the index of each of its letters in the array.
            */

            const int Coeffic = 65;

            int wInd;
            int wordInd;
            char[] intarr = new char[26];

            Console.WriteLine("Write a word:");
            string word = Console.ReadLine().ToUpper();

            for (int i = 65; i < 91; i++)
            {
                intarr[i - Coeffic] = (char)i;
            }

            for (int i = 0; i < (word.Length); i++)
            {
                wordInd = Array.IndexOf(intarr, word[i]);
                Console.WriteLine("{0}", wordInd);
            }

        }

    }
}
