using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void drawTopAndBottom(int n)
        {
            int leftRightStars = n * 2;
            int emptySpace = n;
            Console.Write(new string('*', leftRightStars));
            Console.Write(new string(' ', emptySpace));
            Console.Write(new string('*', leftRightStars));

            Console.WriteLine();
        }



        static void middleRows(int n)
        {
            int rows = 0;

            if (n == 3)
            {
                rows = n / 2;
            }
            else
            {
                rows = (n + 1) / 2;
            }




            int middleRow = (n - 2) / 2;
            int inBorder = (n * 2) - 2;
            int borderInMiddle = n;

            for (int i = 0; i < n - 2; i++)
            {
                if (i == middleRow)
                {
                    Console.Write("*");
                    Console.Write(new string('/', inBorder));
                    Console.Write("*");
                    Console.Write(new string('|', borderInMiddle));
                    Console.Write("*");
                    Console.Write(new string('/', inBorder));
                    Console.Write("*");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', inBorder));
                    Console.Write("*");
                    Console.Write(new string(' ', borderInMiddle));
                    Console.Write("*");
                    Console.Write(new string('/', inBorder));
                    Console.Write("*");
                    Console.WriteLine();
                }
                
            }


        }




        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            drawTopAndBottom(n);
            middleRows(n);
            drawTopAndBottom(n);

        }
    }
}
