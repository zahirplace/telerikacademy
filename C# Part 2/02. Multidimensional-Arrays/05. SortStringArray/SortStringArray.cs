using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortStringArray
{
    class SortStringArray
    {
        static void Main(string[] args)
        {
            /*
             5. You are given an array of strings. Write a method that sorts the array by the length of its elements 
             (the number of characters composing them).
             */

            string[] stringsArr = { "fff", "mmmmm", "cc", "ggggggg", "bbbb", "aaa" };
            Console.WriteLine("Unsorted array: {0}", String.Join(" ", stringsArr));
          
            int maxWord = GetMaxWordLength(stringsArr);
            List<string>[] stringList = new List<string>[maxWord + 1];
            
            InitializeStringList(stringList);
            FillStringList(stringList, stringsArr);
            
            WriteList(stringList);            
        }

        static int GetMaxWordLength(string[] stringsArr)
        {
            string maxWord = stringsArr[0];
            for (int i = 1; i < stringsArr.Length; i++)
            {
                if (maxWord.Length < stringsArr[i].Length)
                {
                    maxWord = stringsArr[i];
                }
            }
            return maxWord.Length;
        }

        static void InitializeStringList(List<string>[] stringList)
        {
            for (int i = 0; i < stringList.Length; i++)           
            {
                stringList[i] = new List<string>();
            }
        }

        static void FillStringList(List<string>[] stringList, string[] stringsArr)
        {
            for (int i = 0; i < stringsArr.Length; i++)
            {
                int wordL = stringsArr[i].Length;
                stringList[wordL].Add(stringsArr[i]);
            }
        }

        static void WriteList(List<string>[] array)
        {
            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Count != 0)
                {
                    foreach (string str in array[i])
                    {
                        Console.Write("{0} ", str);
                    }
                }
            }
            Console.WriteLine();
        }       

    }
}
