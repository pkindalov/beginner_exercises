using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            //fill the matrix
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] readCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = readCols[cols];
                }

            }

            int primaryDiagonal = 0;
            int secondDiagonal = 0;
            int difference = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (rows == cols)
                    {
                        primaryDiagonal += matrix[rows, cols];
                    }

                    //Обхожда колоните отзад-напред :)
                    if (cols == matrixSize - 1 - rows)
                    {
                        secondDiagonal += matrix[rows, cols];
                    }
                }
            }


            //Console.WriteLine(primaryDiagonal);
            //Console.WriteLine(secondDiagonal);
            difference = Math.Abs(primaryDiagonal - secondDiagonal);
            Console.WriteLine(difference);
            //check is it fill right
            //for (int r = 0; r < matrix.GetLength(0); r++)
            //{
            //    for (int c = 0; c < matrix.GetLength(1); c++)
            //    {
            //        Console.Write(matrix[r, c] + " ");
            //    }
            //    Console.WriteLine();
            //}





        }
    }
}
