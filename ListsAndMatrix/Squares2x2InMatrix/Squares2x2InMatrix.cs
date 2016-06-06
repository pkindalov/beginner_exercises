using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares2x2InMatrix
{
    class Squares2x2InMatrix
    {
        static void Main(string[] args)
        {
            long[] matrixSize = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray();

            long matrixRows = matrixSize[0];
            long matrixCols = matrixSize[1];

            char[,] matrix = new char[matrixRows, matrixCols];

            //fill the matrix
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] letters = Console.ReadLine().Trim().Split().Select(char
                    .Parse).ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = letters[c];
                }
            }


            
            long count = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    if ((long)matrix[rows, cols] == matrix[rows, cols + 1] &&
                        matrix[rows, cols] == matrix[rows + 1, cols + 1] &&
                        matrix[rows, cols] == matrix[rows + 1, cols])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);



            //just test is the matrix is filled right
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
