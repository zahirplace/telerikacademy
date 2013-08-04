using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadOperators
{
    class OverloadOperators
    {
        static void Main(string[] args)
        {
            /*
             6*. Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
             subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
             */

            Matrix matrixFirst = new Matrix(2, 3);
            Matrix matrixSecond = new Matrix(3, 4);
            Matrix matrixThird = new Matrix(3, 4);

            Matrix matrixTempOne = new Matrix(3, 4);

            //Initialize the matrixes with random values
            matrixFirst.InitMatrix(100);
            matrixSecond.InitMatrix(50);
            matrixThird.InitMatrix(25);
            
            //Print the matrixes
            Console.WriteLine("A =\n{0}", matrixFirst.ToString());
            Console.WriteLine("B =\n{0}", matrixSecond.ToString());
            Console.WriteLine("C =\n{0}", matrixThird.ToString());

            try
            {
                //Multiply Matrixes
                matrixTempOne = matrixFirst * matrixSecond;
                Console.WriteLine("(A * B) =\n{0}", matrixTempOne.ToString());

                //Subtract Matrixes
                matrixTempOne = matrixSecond - matrixThird;
                Console.WriteLine("(B - C) =\n{0}", matrixTempOne.ToString());

                //Sum Matrixes
                matrixTempOne = matrixSecond + matrixThird;
                Console.WriteLine("(B + C) =\n{0}", matrixTempOne.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: {0}", ex.Message);
            }

        }

        class Matrix
        {
            private int[,] matrix;
            private int rows;
            private int columns;

            public int Rows
            {
                get { return this.rows; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("The number of rows can't be a negative number!");
                    }
                    this.rows = value;
                }
            }

            public int Columns
            {
                get { return this.columns; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("The number of colums can't be a negative number!");
                    }
                    this.columns = value;
                }
            }

            //Indexer for accessing the matrix content
            public int this[int i, int j]
            {
                get
                {
                    return this.matrix[i, j];
                }
                set
                {
                    this.matrix[i, j] = value;
                }
            }

            public Matrix()
                : this(0, 0)
            {
            }

            public Matrix(int rows, int cols)
            {
                this.Rows = rows;
                this.Columns = cols;
                this.matrix = new int[Rows, Columns];
            }

            public static Matrix operator +(Matrix first, Matrix second)
            {
                if (first.Rows != second.Rows || first.Columns != second.Columns)
                {
                    throw new ArgumentException("Different dimensions!");
                }

                Matrix matrix = new Matrix(first.Rows, first.Columns);
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Columns; j++)
                    {
                        matrix[i, j] = first[i, j] + second[i, j];
                    }
                }
                return matrix;
            }

            public static Matrix operator -(Matrix first, Matrix second)
            {
                if (first.Rows != second.Rows || first.Columns != second.Columns)
                {
                    throw new ArgumentException("Different dimensions!");
                }

                Matrix matrix = new Matrix(first.Rows, first.Columns);
                for (int i = 0; i < matrix.Rows; i++)
                {
                    for (int j = 0; j < matrix.Columns; j++)
                    {
                        matrix[i, j] = first[i, j] - second[i, j];
                    }
                }
                return matrix;

            }

            public static Matrix operator *(Matrix first, Matrix second)
            {
                if (first.Columns != second.Rows)
                {
                    throw new ArgumentException("Different dimensions!");
                }

                Matrix resultMatrix = new Matrix(first.Rows, second.Columns);
                for (int row = 0; row < first.Rows; row++)
                {
                    for (int col = 0; col < second.Columns; col++)
                    {
                        resultMatrix[row, col] = 0;
                        for (int i = 0; i < first.Columns; i++)
                        {
                            resultMatrix[row, col] += first[row, i] * second[i, col];
                        }
                    }
                }

                return resultMatrix;
            }

            public override string ToString()
            {
                StringBuilder arrayAsString = new StringBuilder();
                for (int i = 0; i < this.Rows; i++)
                {
                    for (int j = 0; j < this.Columns; j++)
                    {
                        arrayAsString.AppendFormat("{0,6}", this[i, j]);
                    }
                    arrayAsString.Append("\n");
                }

                return arrayAsString.ToString();
            }

            public void InitMatrix(int maxValue)
            {
                Random randomGenerator = new Random();
                for (int i = 0; i < this.Rows; i++)
                {
                    for (int j = 0; j < this.Columns; j++)
                    {
                        this[i, j] = randomGenerator.Next(maxValue);
                    }
                }
            }
        }
    }
}
