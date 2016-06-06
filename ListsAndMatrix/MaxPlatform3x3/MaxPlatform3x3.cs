using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlatform3x3
{
    class MaxPlatform3x3
    {
        static void Main(string[] args)
        {
            int[] matrixRowsCols = Console.ReadLine().Split().Select(int
                .Parse).ToArray();

            int matrixRows = matrixRowsCols[0];
            int matrixCols = matrixRowsCols[1];

            int[,] matrix = new int[matrixRows, matrixCols];


            //fill the matrix
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] someNumbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = someNumbers[c];
                }
            }



            long maxSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
                {
                    long sum = (long)matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] +
                         matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] +
                         matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestRow = rows;
                        bestCol = cols;
                    }
                }
            }

            Console.WriteLine(maxSum);

            for (int rows = bestRow; rows < bestRow + 3; rows++)
            {
                for (int cols = bestCol; cols < bestCol + 3; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }


            //test if the matrix is filled right
            //for (int rows = 0; rows < matrix.GetLength(0); rows++)
            //{
            //    for (int cols = 0; cols < matrix.GetLength(1); cols++)
            //    {
            //        Console.Write(matrix[rows, cols] + " ");
            //    }
            //    Console.WriteLine();
            //}



        }
    }
}
