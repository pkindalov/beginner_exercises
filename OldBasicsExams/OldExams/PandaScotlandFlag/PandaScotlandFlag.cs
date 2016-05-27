using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaScotlandFlag
{
    class PandaScotlandFlag
    {

       





        static void Main(string[] args)
        {


            //for (int i = 0; i < 10; i++)
            //{
            //    char letter = (char)(64 + (i + 1));
            //    Console.WriteLine(letter + " " + i);
            //    //int letterNumber = (int)i  - 64;
            //    //Console.WriteLine(letterNumber); 

            //}


            int rows = int.Parse(Console.ReadLine());
            int width = rows;
            int diez = rows - 2;
            int dots = rows - 2;
            int middle = 0;
            int midLeftAndRigh = rows / 2;
            int rightLeft = 0;
            int rightToLeftBottomPyr = (width - 3) / 2;
            char letter = 'B';
           


            int topPyramideRows = (rows + 1) / 2;
            for (int i = 0; i < topPyramideRows; i++)
            {
                middle = topPyramideRows - 1;
                //проверяваме дали сме на първи ред
                if (i == 0)
                {
                    Console.Write("A");
                    Console.Write(new string('#', diez));
                    Console.WriteLine(letter);

                }

                //сега проверяваме дали сме на средния ред, който е последен в горната пирамида. Понеже деля пирамидата на 2 части, в горната пирамида се включва и средния ред, който се явява последен.

                
                else if (i == middle)
                {
                    Console.Write(new string('-', midLeftAndRigh));
                    letter++;
                    Console.Write(letter);
                    Console.WriteLine(new string('-', midLeftAndRigh));
                }

                //тук са редовете между покрива и средата - междинни и динамични редове според входнто число

                else
                {
                    rightLeft = i;
                    Console.Write(new string('~', rightLeft));
                    letter++;
                    Console.Write(letter);
                    Console.Write(new string('#', diez - (i + 1)));
                    letter++;
                    Console.Write(letter);
                    Console.Write(new string('~', rightLeft));
                    diez--;
                    Console.WriteLine();
                }

            }
            /////////////////////////////////////////////////////////////////////////////////////////


            //долна пирамида , която започва от row / 2
            int rowBottom = rows / 2;
            diez = 1;

            for (int i = 0; i < rowBottom; i++)
            {

                //проверяваме дали сме на последния ред
                if (i == (rowBottom - 1))
                {
                    if (letter >= 'Z')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter++;
                    }
                    
                    Console.Write(letter);
                    Console.Write(new string('#', diez));
                    if (letter >= 'Z')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter++;
                    }
                    Console.Write(letter);

                    Console.WriteLine();
                }


                else
                {    
                    Console.Write(new string('~', rightToLeftBottomPyr));
                    if (letter >= 'Z')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter++;
                    }
                    Console.Write(letter);
                    
                    Console.Write(new string('#', diez));
                    if (letter >= 'Z')
                    {
                        letter = 'A';
                    }
                    else
                    {
                        letter++;
                    }
                    Console.Write(letter);
                    Console.Write(new string('~', rightToLeftBottomPyr));
                    diez += 2;
                    rightToLeftBottomPyr--;   
                    Console.WriteLine();
                }
                //тук са всички останали редове без последния
            }





            

            //char letter = (char)(64 + (i + 1));

            ////проверяваме дали сме на първия ред , за да отпечатаме покрива.
            //if (i == 0)
            //{

            //    Console.Write(new string(letter, 1));
            //    Console.Write(new string('#', diez));
            //    letter++;
            //    Console.Write(new string(letter, 1));
            //    Console.WriteLine();
            //}


            //else if (i == middle) //проверяваме дали сме на средния ред
            //{
            //    letter++;
            //    Console.Write(new string('-', dots));
            //    Console.Write(letter);
            //    Console.Write(new string('-', dots));
            //    Console.WriteLine();
            //}

            //else if (i == n - 1) //проверяваме дали сме на последния ред за пода 
            //{
            //    letter++;
            //    Console.Write(new string(letter, 1));
            //    Console.Write(new string('#', diez));
            //    letter++;
            //    Console.Write(new string(letter, 1));
            //    Console.WriteLine();

            //}

            //letter++;
        }

            
        }
    }

