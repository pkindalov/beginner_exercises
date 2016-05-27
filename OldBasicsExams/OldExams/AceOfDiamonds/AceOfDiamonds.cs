using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfDiamonds
{
    class AceOfDiamonds
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            //top
            Console.WriteLine(new string('*', n));

            int middleRow = (n - 2) / 2;
            
            //middle part
            for (int i = 0; i < n - 2; i++)
            {
                

                //check for middle row
                if (i == middleRow)                //(i == (i + 1) / 2)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('@', n - 2));
                    Console.Write(new string('*', 1));
                    Console.WriteLine();
                }
                else if (i > middleRow)
                {
                    //after middle code
                    int dots = i - (n - 3) / 2;
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', dots));
                    Console.Write(new string('@', (n - i)  / 2));
                    Console.WriteLine();

                   

                }
                else
                {
                    int dots = (n - 3) / 2 - i;
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', dots));
                    Console.Write(new string('@', (i + 1) + i));
                    Console.Write(new string('-', dots));
                    Console.Write(new string('*', 1));
                    Console.WriteLine();
                }




            }


            //bottom
            Console.WriteLine(new string('*', n));
        }
    }
}
