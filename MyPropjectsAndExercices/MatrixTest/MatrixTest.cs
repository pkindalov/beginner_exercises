using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTest
{


    class MatrixTest
    {
        
        //timer experiments
        //static void Main(string[] args)
        //{
        //    var origRow = Console.CursorTop;
        //    for (int a = 10; a >= 0; a--)
        //    {
        //        Console.SetCursorPosition(0, origRow);
        //        Console.Write("Generating Preview in {0}", a);
        //        System.Threading.Thread.Sleep(1000);
        //    }
        //    Console.SetCursorPosition(0, origRow);
        //    Console.Write("Generating Preview done.....");
            //for (int a = 10; a >= 0; a--)
            //{
            //    Console.Write("\rGenerating Preview in {0}", a);
            //    System.Threading.Thread.Sleep(1000);
            //}
            //for (int a = 10; a >= 0; a--)
            //{

            //    Console.CursorLeft = 22;
            //    Console.Write(a.ToString());
            //    System.Threading.Thread.Sleep(1000);
            //    Console.Write("Generating Preview in {0}", a);
            //}

            //for (int a = 10; a >= 0; a--)
            //{
            //    Console.SetCursorPosition(0, 2);
            //    Console.Write("Generating Preview in {0}", a);
            //    System.Threading.Thread.Sleep(1000);
            //}
            //        Random rand = new Random();
            //        Console.WriteLine("Enter ROWS of matrix");
            //        int matrixRows = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter COLS of matrix");
            //        int matrixCols = int.Parse(Console.ReadLine());


            //        Console.WriteLine("Do you want help ? (see the numbers of rows and cols");
            //        Console.WriteLine("Answer with YES or NO. No matter upper or lowercase");
            //        string help = Console.ReadLine().ToLower();

            //        int[,] matrix = new int[matrixRows, matrixCols];

            //        if (help == "yes")
            //        {


            //            for (int rows = 0; rows < matrixRows; rows++)
            //            {
            //                //if (countCols < matrixCols)
            //                //{
            //                //    Console.Write(new string(' ', 7)+ "cols" + countCols + new string(' ', 5));
            //                //}
            //                //countCols++;

            //                for (int i = 0; i < matrixCols; i++)
            //                {
            //                    Console.Write(new string(' ', 6) + "cols" + i);
            //                }

            //                Console.WriteLine();

            //                Console.Write("row" + rows + new string(' ', 2));

            //                for (int cols = 0; cols < matrixCols; cols++)
            //                {
            //                    //Console.Write("cols" + cols + new string(' ', 5));
            //                    matrix[rows, cols] = rand.Next(11, 101);
            //                    Console.Write(matrix[rows, cols] + new string(' ', 10));

            //                }
            //                Console.WriteLine();
            //                Console.WriteLine();
            //            }
            //        }
            //        else
            //        {
            //            for (int rows = 0; rows < matrixRows; rows++)
            //            {
            //                for (int cols = 0; cols < matrixCols; cols++)
            //                {
            //                    matrix[rows, cols] = rand.Next(11, 101);
            //                    Console.Write(matrix[rows, cols] + new string(' ', 5));
            //                }
            //                Console.WriteLine();
            //            }
            //        }




            //        //int[,] matrix = new int[matrixRows, matrixCols];




            //        //Console.WriteLine("Enter row: ");
            //        //int userRow = int.Parse(Console.ReadLine());
            //        //Console.WriteLine("Enter col: ");
            //        //int userCol = int.Parse(Console.ReadLine());

            //        //Console.WriteLine(matrix[userRow, userCol]);
            //        int guessingRow = rand.Next(0, matrixRows);
            //        int guessingCol = rand.Next(0, matrixCols);

            //        //Console.WriteLine("Choose the right position on element from matrix {0}", matrix[rand.Next(0, matrixRows), rand.Next(0, matrixCols)]);

            //        Console.WriteLine("Choose the right position on element from matrix {0}", matrix[guessingRow, guessingCol]);
            //        Console.WriteLine("If the element repeats, the latest is true");

            //        Console.WriteLine("Row: ");
            //        int userRow = int.Parse(Console.ReadLine());
            //        if (userRow > matrixRows)
            //        {
            //            Console.WriteLine("There is no such row. Please try again");
            //            return;
            //        }

            //        Console.WriteLine("Col: ");
            //        int userCol = int.Parse(Console.ReadLine());
            //        if (userCol > matrixCols - 1)
            //        {
            //            Console.WriteLine("There is no such cow. Please try again");
            //            return;
            //        }


            //        for (int rows = 0; rows < matrixRows; rows++)
            //        {
            //            for (int cols = 0; cols < matrixCols; cols++)
            //            {
            //                if (matrix[userRow, userCol] == matrix[guessingRow, guessingCol])
            //                {
            //                    Console.WriteLine("Bravo ! You guess. Excellent work");
            //                    return;
            //                }
            //                else
            //                {
            //                    int rightRow = 0;
            //                    int rightCol = 0;
            //                    for (int row = 0; row < matrixRows; row++)
            //                    {
            //                        for (int col = 0; col < matrixCols; col++)
            //                        {
            //                            if(matrix[row, col] == matrix[guessingRow, guessingCol])
            //                            {
            //                                rightRow = row;
            //                                rightCol = col;

            //                            }
            //                        }
            //                    }



            //                    Console.WriteLine("Wrong answer. The right answer is row: {0} col: {1}. Please try again.", rightRow, rightCol );
            //                    return;
            //                }
            //            }
            //        }



        }
    }
}
