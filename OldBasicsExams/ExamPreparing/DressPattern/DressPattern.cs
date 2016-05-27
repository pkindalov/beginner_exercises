using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressPattern
{
    class DressPattern
    {

        static void drawTop(int n, int totalWidth)
        {
            int rows = n * 2;
            int leftAndRight = n * 4;
            
            for (int i = 0; i < rows; i++)
            {
                int stars = (i * 2);
                if (i > 1)
                {
                    stars += i - 1;
                }
                Console.Write(new string('_', leftAndRight));
               
                //draw first left pyramid
                if (stars == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(".");
                    Console.Write(new string('*', stars));
                    Console.Write(".");
                }


                Console.Write(new string('_', leftAndRight));

                
                //draw second, right pyramid
                if (stars == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(".");
                    Console.Write(new string('*', stars));
                    Console.Write(".");
                }

                Console.Write(new string('_', leftAndRight));

                leftAndRight -= 2;

                Console.WriteLine();
            }

        }






        static void drawSecondPart(int n, int width)
        {
            int rows = n + 2;
            int dots = 4;
            int stars = (width - dots) / 2;

            for (int i = 0; i < rows; i++)
            {
                
                //Проверява дали сме на първи ред, защото е по-различен от следващите два 
                if (i == 0)
                {
                    Console.Write(".");
                    Console.Write(new string('*', stars));
                    Console.Write(new string('.', 2));
                    Console.Write(new string('*', stars));
                    Console.Write(".");
                }
                //проверя дали сме на последния ред, защото и той е по-различен от средните два
                else if (i == (rows - 1))
                {
                    dots = n * 3;
                    stars = width - (dots * 2);


                    Console.Write(new string('.', dots));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('.', dots));
                }
                //тук печата средните редове
                else
                {
                    stars = width - 2;
                    Console.Write(".");
                    Console.Write(new string('*', stars));
                    Console.Write(".");
                }
               

                Console.WriteLine();
            }
        }



        //чертае колана
        static void drawBelt(int n, int width)
        {
            int dashes = n * 3;
            int zeroes = width - (dashes * 2);

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('_', dashes));
                Console.Write(new string('o', zeroes));
                Console.Write(new string('_', dashes));
                Console.WriteLine();
            }

        }



        //чертае долната част на роклята
        static void drawBottomOfDress(int n, int width)
        {
            int rows = n * 3;
            int leftRight = n * 3;
            int starsStartFrom = width - (leftRight * 2) - 2;

            for (int i = 0; i < rows; i++)
            {
                Console.Write(new string('_', leftRight));
                
               
                
                
                if (i > 0)
                {
                    starsStartFrom += 2;
                }
                Console.Write(".");
                
                Console.Write(new string('*', starsStartFrom));
                Console.Write(".");
                Console.Write(new string('_', leftRight));


                leftRight--;
                Console.WriteLine();
            }

        }





        //Чертае последния ред с точките
        static void drawLastRowDots(int width)
        {
            Console.WriteLine(new string('.', width));
        }






        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalWidth = (12 * n) + 2;

            drawTop(n, totalWidth);
            drawSecondPart(n, totalWidth);
            drawBelt(n, totalWidth);
            drawBottomOfDress(n, totalWidth);
            drawLastRowDots(totalWidth);

        }
    }
}
