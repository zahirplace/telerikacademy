using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            /*
             Write a program that reads two arrays from the console and compares them element by element.
             */


            int[] IniArray1 = new int[5];
            int[] IniArray2 = new int[5];
            ReadIntArr(IniArray1, 1);
            ReadIntArr(IniArray2, 2);

            if (CompareIntArr(IniArray1, IniArray2))
            {
                Console.WriteLine("Arrays are equal!");
            }
            else
            {
                Console.WriteLine("Arrays are different!");
            }
        }

        static int[] ReadIntArr(int[] IntArr, int ArrNum)
        {
            Console.WriteLine("Insert numbers for Array {0}.", ArrNum);
            for (int i = 0; i < IntArr.Length; i++)
            {
                Console.Write("IntArr{0}[{1}]=", ArrNum, i);
                IntArr[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            return IntArr;
        }

        static bool CompareIntArr(int[] IntArr1, int[] IntArr2)
        {
            bool equel = true;
            if (IntArr1.Length == IntArr2.Length)
            {
                for (int i = 0; i < IntArr1.Length; i++)
                {
                    if (IntArr1[i] != IntArr2[i])
                    {
                        equel = false;
                        break;
                    }
                }
            }
            else
            {
                equel = false;
            }
            return equel;
        }

    }
}
