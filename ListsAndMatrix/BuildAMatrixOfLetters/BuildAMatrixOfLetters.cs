using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAMatrixOfLetters
{
    class BuildAMatrixOfLetters
    {
        static void Main(string[] args)
        {

            var matrix = new char[3, 7];

            

            char letter = 'A';

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = letter;
                    letter++;
                    if (letter > 'Z')
                    {
                        letter = 'A';
                    }
                }

            }




            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();

            }








        }
    }
}
