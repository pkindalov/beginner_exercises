using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWithAWindow
{
    class HouseWithAWindow
    {
        //drawing roof
        static void drawRoof(int n, int width, int totalheight)
        {
            int roof = n;
            int starsCount = 1;
            int leftRightDots = (width - starsCount) / 2;
            int middleDots = 0;

            for (int i = 0; i < n; i++)
            {

                Console.Write(new string('.', leftRightDots));
                Console.Write(new string('*', starsCount));
                Console.Write(new string('.', middleDots));
                if (i > 0)
                {
                    Console.Write(new string('*', starsCount));
                }

                Console.Write(new string('.', leftRightDots));

                if (leftRightDots > 0)
                {
                    leftRightDots--;
                }

                if (middleDots >= 1)
                {
                    middleDots += 2;
                }
                else
                {
                    middleDots++;
                }
                Console.WriteLine();
            }
        }

        



        //drawing house base
        static void drawBase(int n, int width)
        {
            int houseBase = n + 2;
            for (int i = 0; i < houseBase; i++)
            {
                //find first row for stars
                if (i == 0)
                {
                    Console.WriteLine(new string('*', width));
                   
                }
                //find last row for stars
                else if (i == houseBase - 1)
                {
                    Console.WriteLine(new string('*', width));
                }

                //any left rows between top and bottom
                else
                {
                    int dots = width - 2;
                    int windowHeight = n / 2;
                    int windowWidth = n - 3;

                    if (i == windowHeight)
                    {
                        dots = (width - 2 - windowHeight) / 2;
                        Console.Write("*");
                        Console.Write(new string('.', dots));
                        Console.WriteLine("*");
                        
                    }
                    else
                    {
                        Console.Write("*");
                        Console.Write(new string('.', dots));
                        Console.WriteLine("*");
                    }
                    
                }
            }



        }



        //draw one fort of house base
        static void oneForth(int n, int width)
        {
            int rows = n / 4;

            for (int i = 0; i < rows; i++)
            {
                Console.Write("*");
                Console.Write(new string('.', width - 2));
                Console.WriteLine("*");
            }

        }


        //draw middle part
        static void drawMiddle(int n, int width)
        {
            int rows = n / 2;
            int leftRightDots = n / 2;
            int middleStars = (width - 2) - (leftRightDots * 2);
            
            for (int i = 0; i < rows; i++)
            {
                Console.Write("*");
                Console.Write(new string('.', leftRightDots));
                Console.Write(new string('*', middleStars));
                Console.Write(new string('.', leftRightDots));
                Console.WriteLine("*");

            }
        }



        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (n * 2) - 1;
            int totalHeigt = (2 * n) + 2;
            

            drawRoof(n, width, totalHeigt);
            //drawBase(n, width);
            Console.WriteLine(new string('*', width));
            oneForth(n, width);
            drawMiddle(n, width);
            oneForth(n, width);
            Console.WriteLine(new string('*', width));

        }
    }
}
