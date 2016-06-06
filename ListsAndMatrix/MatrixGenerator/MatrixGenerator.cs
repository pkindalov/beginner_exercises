using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixGenerator
{
    class MatrixGenerator
    {
        static void Main(string[] args)
        {
            string[] inputInformation = Console.ReadLine().Trim().Split().ToArray();
            char type = char.Parse(inputInformation[0]);

            int matrixRows = int.Parse(inputInformation[1]);
            int matrixCols = int.Parse(inputInformation[2]);

            int maxNumbersInMatrix = matrixRows * matrixCols;

            if (type == 'A')
            {
                //first fill the matrix
                for (int cols = 0; cols < matrixCols; cols++)
                {
                    
                }


            }



        }
    }
}
