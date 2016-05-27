using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (2 * n) - 1;            //общо всички символи на ред - ширина.
            int height = 2 * (n - 2) + 1;       //брой редове - височина
            int middleRow = height / 2;         //намира средния ред
            int leftRightStars = n - 2;         //изчислява броят звезди от двете страни

            for (int i = 0; i < height; i++)        //въртим цикъл до височината(броят редове)
            {
                if (i < middleRow)    //Ако текущата итерация на цикъла е преди средата
                {
                    if (i % 2 != 0)    //Проверяваме дали редът е четен или не и спрямо това отпечатваме
                                       // - или *
                    {
                        Console.Write(new string('-', leftRightStars));
                        Console.Write("\\");
                        Console.Write(" ");
                        Console.Write("/");
                        Console.Write(new string('-', leftRightStars));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(new string('*', leftRightStars));
                        Console.Write("\\");
                        Console.Write(" ");
                        Console.Write("/");
                        Console.Write(new string('*', leftRightStars));
                        Console.WriteLine();
                    }
                   
                }
                else if (i == middleRow)            //Ако сме на средния ред в текущата итерация
                {
                    Console.Write(new string(' ', n - 1));      //n-1 изчислява празните пространства от                                           лявата и дясната страна на @
                    Console.Write("@");
                    Console.WriteLine(new string(' ', n - 1));
                }
                else                    //Ако сме на ред след средата в текущата итерация
                {
                    if (i % 2 != 0)    //Отново проверяваме дали редът е четен или не и спрямо това                      използваме съответно - или *
                    {
                        Console.Write(new string('-', leftRightStars));
                        Console.Write("/");
                        Console.Write(" ");
                        Console.Write("\\");
                        Console.Write(new string('-', leftRightStars));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(new string('*', leftRightStars));
                        Console.Write("/");
                        Console.Write(" ");
                        Console.Write("\\");
                        Console.Write(new string('*', leftRightStars));
                        Console.WriteLine();
                    }

                    
                }
                
            }


        }
    }
}
