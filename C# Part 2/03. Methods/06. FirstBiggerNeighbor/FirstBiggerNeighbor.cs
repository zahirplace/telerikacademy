using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstBiggerNeighbor
{
    class FirstBiggerNeighbor
    {
        static void Main(string[] args)
        {
            /*6. Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.
 */


            int[] arrOfInteger = { 1, 2, 7, 8, 10, 7, 4, 5 };

            int elemIndex = GetFirstBiggerElementIndex(arrOfInteger);

            Console.WriteLine(elemIndex);
        }


        static int GetFirstBiggerElementIndex(int[] intArr)
        {
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                if (IsBigger(i, intArr))
                {
                    return i;
                }
            }
            return -1;
        }

        static bool IsBigger(int index, int[] intArr)
        {
            if (index == 0)
            {
                return intArr[index] > intArr[index + 1];
            }

            if (index == intArr.Length - 1)
            {
                return intArr[index] > intArr[index - 1];
            }

            if (intArr[index] <= intArr[index - 1])
            {
                return false;
            }
            else
            {
                return intArr[index] > intArr[index + 1];
            }

        }

    }
}
