using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestSequence
{
    class LongestSequence
    {
        static void Main(string[] args)
        {
            /*
             3. We are given a matrix of strings of size N x M. 
             Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
             Write a program that finds the longest sequence of equal strings in the matrix. Example:
             */

            string[,] matrix = 
		                    {
			                    { "aa",  "mmm", "bb",  "ggg"},
			                    { "ha", "lll", "mmm",  "zzz"},
			                    { "rr",  "ha", "bb",  "mmm"},
			                    { "bb",  "kk", "bb", "qqq"}                               
		                    };

            string maxString;
            int maxCount;

            FindMaxSequence(matrix, out maxString, out maxCount);
            PrintLine(maxCount, maxString);
        }

        static void FindMaxSequence(string[,] matrix, out string maxString, out int maxCount)
        {
            maxString = matrix[0, 0];
            maxCount = 1;

            int currentCount = 1;
            bool equal = false;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    //check right direction     
                    currentCount = 1;
                    for (int i = col; i < matrix.GetLength(1) - 1; i++)
                    {
                        if (matrix[row, col] == matrix[row, i + 1])
                        {
                            currentCount++;
                            equal = true;
                        }
                        else
                            break;
                    }
                    if ((equal == true) && (currentCount > maxCount))
                    {
                        maxCount = currentCount;
                        maxString = matrix[row, col];
                        equal = false;
                    }

                    //check down direction
                    currentCount = 1;
                    for (int i = row; i < matrix.GetLength(0) - 1; i++)
                    {
                        if (matrix[row, col] == matrix[i + 1, col])
                        {
                            currentCount++;
                            equal = true;
                        }
                        else
                            break;
                    }
                    if ((equal == true) && (currentCount > maxCount))
                    {
                        maxCount = currentCount;
                        maxString = matrix[row, col];
                        equal = false;
                    }

                    //check right diagonal
                    currentCount = 1;
                    int currentRow = row + 1;
                    int currentCol = col + 1;
                    while ((currentRow < matrix.GetLength(0)) && (currentCol < matrix.GetLength(1)))
                    {
                        if (matrix[row, col] == matrix[currentRow, currentCol])
                        {
                            currentCount++;
                            equal = true;
                        }
                        else
                            break;

                        currentRow++;
                        currentCol++;
                    }

                    if ((equal == true) && (currentCount > maxCount))
                    {
                        maxCount = currentCount;
                        maxString = matrix[row, col];
                        equal = false;
                    }

                    //check left diagonal
                    currentCount = 1;
                    currentRow = row + 1;
                    currentCol = col - 1;
                    while ((currentRow < matrix.GetLength(0)) && (currentCol < matrix.GetLength(1)) &&
                            (currentRow >= 0) && (currentCol >= 0))
                    {
                        if (matrix[row, col] == matrix[currentRow, currentCol])
                        {
                            currentCount++;
                            equal = true;
                        }
                        else
                            break;

                        currentRow++;
                        currentCol--;
                    }

                    if ((equal == true) && (currentCount > maxCount))
                    {
                        maxCount = currentCount;
                        maxString = matrix[row, col];
                        equal = false;
                    }
                }
            }

        }

        static void PrintLine(int maxCount, string maxString)
        {
            for (int i = 0; i < maxCount - 1; i++)
            {
                Console.Write("{0}, ", maxString);
            }
            Console.WriteLine("{0}", maxString);
        }

    }
}
