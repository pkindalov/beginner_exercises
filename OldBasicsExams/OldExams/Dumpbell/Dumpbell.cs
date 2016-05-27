using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumpbell
{
    class Dumpbell
    {
        //draw top of the dumpbell - first line
        static void drawTopAndBottom(int n)
        {
            int sideDots = n / 2;
            int amp = (n + 1) / 2;
            int middleDots = n;

            Console.Write(new string('.', sideDots));
            Console.Write(new string('&', amp));
            Console.Write(new string('.', middleDots));
            Console.Write(new string('&', amp));
            Console.Write(new string('.', sideDots));

            Console.WriteLine();
        }


        //draw middle part of dumpbell - middle line
        static void drawMiddle(int n)
        {
            int stars = n - 2;
            int handlleMiddle = n;
            Console.Write("&");
            Console.Write(new string('*', stars));
            Console.Write("&");
            Console.Write(new string('=', handlleMiddle));
            Console.Write("&");
            Console.Write(new string('*', stars));
            Console.Write("&");

            Console.WriteLine();
        }



        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            drawTopAndBottom(n);

            int betweenTopAndMiddleRows = (n / 2) - 1;
            for (int i = 0; i < betweenTopAndMiddleRows; i++)
            {
                int sideDots = (n / 2) - (i + 1);
                int stars = (n / 2) + i;
                int middleDots = n;
                Console.Write(new string('.', sideDots));
                Console.Write("&");
                Console.Write(new string('*', stars));
                Console.Write("&");
                Console.Write(new string('.', middleDots));
                Console.Write("&");
                Console.Write(new string('*', stars));
                Console.Write("&");
                Console.Write(new string('.', sideDots));

                Console.WriteLine();
            }

            
            drawMiddle(n);

            for (int i = 0; i < betweenTopAndMiddleRows; i++)
            {
                int sideDots = i + 1;
                int stars = (n - 2) - 1 - i;
                int middleDots = n;
                Console.Write(new string('.', sideDots));
                Console.Write("&");
                Console.Write(new string('*', stars));
                Console.Write("&");
                Console.Write(new string('.', middleDots));
                Console.Write("&");
                Console.Write(new string('*', stars));
                Console.Write("&");
                Console.Write(new string('.', sideDots));

                Console.WriteLine();
            }

            drawTopAndBottom(n);
        }
    }
}
