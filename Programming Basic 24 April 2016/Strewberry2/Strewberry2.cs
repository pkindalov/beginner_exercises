using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strewberry2
{
    class Strewberry2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalRowsPicture = (n * 2) + 1;

            char shitSign = '\\';
            Console.WriteLine(shitSign + new string('-', n) + "|" + new string('-', n) + "/");


            int leftRightDots = 2;
            int middleDots = n - 2;
            int middleDots2 = n;
            int dots = n - 2;
            int rowsWidth = (n * 2) + 3;


            for (int i = 0; i < n * 2; i++)
            {
                int top = n / 2;
               
                if (i >= 0 && i < top)
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
                else if(i == top)
                {
                    int leftRightDdots = n;

                    Console.Write(new string('-', leftRightDdots));
                    Console.Write("#.#");
                    Console.WriteLine(new string('-', leftRightDdots));
                }
                else if (i > top && dots > 0)
                {
                    middleDots2 = rowsWidth - (dots * 2) - 2;
                    Console.Write(new string('-', dots));
                    

                    Console.Write("#");
                    
                    Console.Write(new string('.', middleDots2));
                    Console.Write("#");
                    Console.Write(new string('-', dots));

                    if (dots > 0)
                    {
                        if ((dots -= 2) < 0)
                        {
                            dots = 0;
                        }

                    }
                    middleDots2 += 2;
                    Console.WriteLine();
                }
                else if (i == (i % 2))
                {
                    Console.WriteLine("Middle row");
                }





            }
        }
    }
}
