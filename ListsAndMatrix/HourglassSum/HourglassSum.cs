using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourglassSum
{
    class HourglassSum
    {
        static void Main(string[] args)
        {
            byte matrixRows = 6;
            byte matrixCols = 6;

            int[,] matrix = new int[matrixRows, matrixCols];

            //fill the matrix
            for (int r = 0; r < matrixRows; r++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < matrixCols; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }




            long maxSum = long.MinValue;

            for (int rows = 0; rows < matrixRows - 2; rows++)
            {
                for (int cols = 0; cols < matrixCols - 2; cols++)
                {
                    long sum = (long)matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] +
                                     matrix[rows + 1, cols + 1] +
                                     matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine(maxSum);


            //check if matrix is filled right.
            //Console.WriteLine();

            //for (int r = 0; r < matrixRows; r++)
            //{
            //    for (int c = 0; c < matrixCols; c++)
            //    {
            //        Console.Write(matrix[r, c] + " ");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
