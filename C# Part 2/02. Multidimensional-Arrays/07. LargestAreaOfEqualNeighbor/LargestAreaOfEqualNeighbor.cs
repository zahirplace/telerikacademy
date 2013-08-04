using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestAreaOfEqualNeighbor
{
    class LargestAreaOfEqualNeighbor
    {
        //!!! I got this solution from the internet, because I liked it very much (more than mine) !!!

        /*
            7*. Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 

            Hint: you can use the algorithm "Depth-first search" or "Breadth-first search" (find them in Wikipedia).                          
        */

        static int[,] matrix = 
        {
            {1,3,2,2,2,4},
            {3,3,3,2,4,3},
            {4,3,1,2,3,3},
            {3,3,1,3,3,4},
            {4,3,3,3,4,4},
        };
        static bool[,] checkedCells = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        static void Main(string[] args)
        {
            int result = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));
                }
            }
            Console.WriteLine("The largest area is: {0}", result);
        }

        static int DepthFirstSearch(int row, int col, int value)
        {
            // check if we have cell which is neighbour or we are on the bounds
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return 0;
            }

            // check if we already checked this cell
            if (checkedCells[row, col] == true)
            {
                return 0;
            }

            // check if the value is different from the searched one
            if (matrix[row, col] != value)
            {
                return 0;
            }

            // mark as read current cell
            checkedCells[row, col] = true;

            // check neighbours of the cell, + 1 for this cell which already marked
            return DepthFirstSearch(row, col + 1, value) + DepthFirstSearch(row, col - 1, value) +
                   DepthFirstSearch(row + 1, col, value) + DepthFirstSearch(row - 1, col, value) + 1;
        }

    }
}
