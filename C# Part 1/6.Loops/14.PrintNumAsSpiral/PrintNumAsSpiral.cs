using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNumAsSpiral
{
    static void Main(string[] args)
    {
        /*
         14.* Write a program that reads a positive integer number N (N < 20) from console and 
              outputs in the console the numbers 1 ... N numbers arranged as a spiral.
                Example for N = 4
             
                    1   2   3 4
                    12  13  14 5
                    11  16  15 6
                    10   9  8  7
        */


        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrixArray = (MakeSpiral(n));
        PrintArray(matrixArray);
    }

    //Method for creating the spiral matrix - taken from Wikipedia
    public static int[,] MakeSpiral(int n)
    {
        int[,] resultArray = new int[n, n];

        int pos = 1;
        int count = n;
        int value = -n;
        int sum = -1;

        do
        {
            value = -1 * value / n;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                resultArray[sum / n, sum % n] = pos++;
            }
            value *= n;
            count--;
            for (int i = 0; i < count; i++)
            {
                sum += value;
                resultArray[sum / n, sum % n] = pos++;
            }
        } while (count > 0);

        return resultArray;
    }

    // Print array
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,4}", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
