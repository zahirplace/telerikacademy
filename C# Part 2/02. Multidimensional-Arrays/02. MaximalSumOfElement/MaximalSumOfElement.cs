using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximalSumOfElement
{
    class MaximalSumOfElement
    {
        static void Main(string[] args)
        {
            /*
             2. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that 
             has maximal sum of its elements.
             */

            int[,] matrix = {
			                    { 1,  2,  3,  4,  5,  6},
			                    { 7, 80,  9, 10, 11, 12},
			                    {13, 14, 15, 16, 17, 18},
			                    {19, 20, 21, 22, 23, 24},
                                {25, 26, 27, 28, 29, 30}
		                    };

            int maxSum;
            int maxRow;
            int maxCol;
            int searchedMatrixSize = 3;

            FindMaxSequence(matrix, out maxSum, out maxRow, out maxCol);
            PrintMaxSumElements(matrix, maxSum, maxRow, maxCol, searchedMatrixSize);
        }


        static void FindMaxSequence(int[,] matrix, out int maxSum, out int maxRow, out int maxCol)
        {
            maxSum = 0;
            maxRow = 0;
            maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                     matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                     matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

        }

        static void PrintMaxSumElements(int[,] matrix, int maxSum, int maxRow, int maxCol, int searchedMatrixSize)
        {
            Console.WriteLine("The elements of max sum are:");
            for (int i = maxRow; i <= searchedMatrixSize; i++)
            {
                for (int j = maxCol; j <= searchedMatrixSize; j++)
                {
                    Console.Write("{0,2} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The maximal sum is: {0}", maxSum);
        }

    }
}
