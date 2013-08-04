using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillAndPrintMatrix
{
    class FillAndPrintMatrix
    {
        static void Main(string[] args)
        {
            /*
             1. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
             */

            int n = 6;
            int[,] MatrixA = new int[n, n];
            int[,] MatrixB = new int[n, n];
            int[,] MatrixC = new int[n, n];
            int[,] MatrixD = new int[n, n];

            FillMatrixA(MatrixA, n);
            FillMatrixB(MatrixB, n);
            FillMatrixC(MatrixC, n);
            FillMatrixD(MatrixD, n);

            PrintMatrix(MatrixA, n);
            PrintMatrix(MatrixB, n);
            PrintMatrix(MatrixC, n);
            PrintMatrix(MatrixD, n);
        }

        static void FillMatrixA(int[,] Matrix, int n)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if ((i == 0) && (j == 0))  //fill the first element
                    {
                        Matrix[i, j] = 1;
                        continue;
                    }
                    if (i == 0) // fill the elements of the first row
                    {
                        Matrix[i, j] = Matrix[n - 1, j - 1] + 1;
                        continue;
                    }
                    // fill the other elements of the row
                    Matrix[i, j] = Matrix[i - 1, j] + 1;
                }
            }
        }

        static void FillMatrixB(int[,] Matrix, int n)
        {
            int row;
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if ((i == 0) && (j == 0))
                    {
                        Matrix[i, j] = 1;
                        continue;
                    }
                    //fill the even columns
                    if (j % 2 == 0)
                    {
                        if (i == 0) // fill the first elements of the even columns
                        {
                            Matrix[i, j] = Matrix[i, j - 1] + 1;
                            continue;
                        }
                        // fill the other elements of the even columns
                        Matrix[i, j] = Matrix[i - 1, j] + 1;
                        continue;
                    }

                    // fill the rows
                    row = (n - 1) - i;
                    if (row == (n - 1))
                    {
                        Matrix[row, j] = Matrix[row, j - 1] + 1;
                        continue;
                    }
                    Matrix[row, j] = Matrix[row + 1, j] + 1;
                }
            }
        }

        static void FillMatrixC(int[,] matrix, int n)
        {
            int counter = 1;

            //fill the first half of the matrix
            for (int row = n - 1; row >= 0; row--)
            {
                int currentRow = row;
                int currentCol = 0;

                while ((currentCol < n) && (currentRow < n))
                {
                    matrix[currentRow, currentCol] = counter;
                    counter++;
                    currentRow++;
                    currentCol++;
                }
            }
            //fill the second half of the matrix
            for (int col = 1; col < n; col++)
            {
                int currentCol = col;
                int currentRow = 0;

                while ((currentCol < n) && (currentRow < n))
                {
                    matrix[currentRow, currentCol] = counter;
                    counter++;
                    currentRow++;
                    currentCol++;
                }
            }
        }

        static void FillMatrixD(int[,] matrix, int N)
        {
            string direction = "down";

            int currentRow = 0;
            int currentCol = 0;

            for (int i = 0; i < N * N; i++)
            {
                if (direction == "down" && (currentRow >= N || matrix[currentRow, currentCol] != 0))
                {
                    currentRow--;
                    currentCol++;
                    direction = "right";
                }
                else if (direction == "right" && (currentCol >= N || matrix[currentRow, currentCol] != 0))
                {
                    currentCol--;
                    currentRow--;
                    direction = "up";
                }
                else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentRow++;
                    currentCol--;
                    direction = "left";
                }
                else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol++;
                    currentRow++;
                    direction = "down";
                }


                matrix[currentRow, currentCol] = i + 1;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }
        }

        static void PrintMatrix(int[,] Matrix, int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,4}", Matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

    }
}
