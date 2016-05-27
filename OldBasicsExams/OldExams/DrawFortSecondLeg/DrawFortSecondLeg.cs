using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFortSecondLeg
{
    class DrawFortSecondLeg
    {

        //Draw top
        static void drawTop(int n, int width)
        {
            int hats = n / 2;
            int middleDots = (width - 4) - (hats * 2);
            Console.Write("/");
            Console.Write(new string('^', hats));
            Console.Write("\\");
            Console.Write(new string('_', middleDots));
            Console.Write("/");
            Console.Write(new string('^', hats));
            Console.WriteLine("\\");


        }



        //draw middle rows
        static void drawMiddle(int n, int width)
        {
            int rows = n - 2;
            for (int i = 0; i < rows; i++)
            {
                int emptySpaces = width - 2;
                if (n > 4 && i == (rows - 1))      //if number is > 4 and i == last row then...
                {
                    int middleDots = n / 2;
                    int dots = width - 2 * middleDots - 4;
                    emptySpaces = middleDots + 1;
                    Console.Write("|");
                    Console.Write(new string(' ', emptySpaces));
                    Console.Write(new string('_', dots));
                    Console.Write(new string(' ', emptySpaces));
                    Console.WriteLine("|");
                    

                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', emptySpaces));
                    Console.WriteLine("|");
                }
                

            }
        }



        //draw bottom 
        static void drawBottom(int n, int width)
        {
            int middleSigns = n / 2;

            if (n < 5)
            {
                
                Console.Write("\\");
                Console.Write(new string('_', middleSigns));
                Console.Write("/");
                Console.Write("\\");
                Console.Write(new string('_', middleSigns));
                Console.WriteLine("/");
            }
            else
            {
                int emptySpaces = (width - 4) - (middleSigns * 2);
                Console.Write("\\");
                Console.Write(new string('_', middleSigns));
                Console.Write("/");
                Console.Write(new string(' ', emptySpaces));
                Console.Write("\\");
                Console.Write(new string('_', middleSigns));
                Console.WriteLine("/");

            }
        }



        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int width = n * 2;

            drawTop(n, width);
            drawMiddle(n, width);
            drawBottom(n, width);

        }
    }
}
