using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Strawberry
    {
        static void drawTop(int n)
        {
            int width = (n * 2) - 3;
            int rows = n / 3;
            int leftRightDots = 2;
            int middleDots = n - 2;

            for (int i = 0; i < rows; i++)
            {
                if (i > 0)
                {
                    leftRightDots += 2;
                }
                Console.Write(new string('-', leftRightDots));
                Console.Write("\\");
                Console.Write(new string('-', middleDots));
                Console.Write("|");
                Console.Write(new string('-', middleDots));
                Console.Write("/");
                Console.Write(new string('-', leftRightDots));
                Console.WriteLine();

                middleDots -= 2;
            }
        }


        static void drawFirstBottomRowAfterTop(int n)
        {
            int leftRightDdots = n;

            Console.Write(new string('-', leftRightDdots));
            Console.Write("#.#");
            Console.WriteLine(new string('-', leftRightDdots));

        }




        static void pyramideTop(int n, int totalwidth)
        {
            int rowsWidth = (n * 2) + 3;
            int dots = n - 2;
            int middleDots = 0;

            int allRows = ((n * 2) - 1) - (n / 3) - 3;

            //if (n <= 5)
            //{
            //    allRows = (allRows / 2);
            //}
            //if (n > 10)
            //{
            //    allRows = (allRows / 2) - 3;
            //}
            //else
            //{
            //    allRows = (allRows / 2) - 1;
            //}

            allRows = (n + 2) / 2; 

            for (int i = 0; i < allRows - 1; i++)
            {

                middleDots = rowsWidth - (dots * 2) - 2;
                Console.Write(new string('-', dots));  
                Console.Write("#");
                Console.Write(new string('.', middleDots));
                Console.Write("#");
                Console.Write(new string('-', dots));

                if (dots > 0)
                {
                    if ((dots -= 2) < 0)
                    {
                        dots = 0;
                    }

                }
                Console.WriteLine();
            }

        }





        static void pyramidBottom(int n)
        {
            int rows = n - 1;
            int dotsCounter = 1;
            int rowsWidth = (n * 2) + 3;
            int middleDots = rowsWidth - dotsCounter - 3;

            for (int i = 0; i < rows; i++)
            {
                //middleDots = rowsWidth - dotsCounter - 2;
                Console.Write(new string('-', dotsCounter));
                Console.Write("#");
                Console.Write(new string('.', middleDots));
                Console.Write("#");
                Console.Write(new string('-', dotsCounter));
                dotsCounter++;
                middleDots -= 2;
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalRowsPicture = (n * 2) + 1;

            char shitSign = '\\';
            Console.WriteLine(shitSign + new string('-', n) + "|" + new string('-', n) + "/");
            drawTop(n);
            drawFirstBottomRowAfterTop(n);
            pyramideTop(n, totalRowsPicture);
            int width = (n * 2) + 3;
            Console.WriteLine("#" + new string('.', width - 2) + "#");
            pyramidBottom(n);
            drawFirstBottomRowAfterTop(n);
        }
    }
}
