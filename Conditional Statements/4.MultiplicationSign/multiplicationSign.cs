using System;
using System.Threading;
using System.Globalization;


    class multiplicationSign
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Problem 4. Multiplication Sign

            //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            //Use a sequence of if operators.


            Console.Write("Enter a number one: ");
            double a = double.Parse(Console.ReadLine().Replace(',' , '.'));
            Console.Write("Enter number two: ");
            double b = double.Parse(Console.ReadLine().Replace(',' , '.'));
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine().Replace(',' , '.'));

            //check if 3 numbers are +
            if( a > 0 && b > 0 && c > 0)  //check if 3 numbers are +
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //check if 2 of 3 number are - 
            else if(a < 0 && b < 0 && c > 0) //check if 1 and 2 numbers are -
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if(a < 0 && c < 0 && b >0) //check if 1 and 3 numbers are - 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if(b < 0 && c < 0 && a > 0) //check if 2 and 3 numbers are - 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+");
                Console.ForegroundColor = ConsoleColor.Gray;
            }


            //check if 1 number of 3 is -
            else if(a < 0 && b > 0 && c > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //check if 2 number of 3 is -
            else if(a > 0 && b <0 && c > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //check if 3 number of 3 is -
            else if(a > 0 && b > 0 && c < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //check if 3 numbers are -
            else if(a < 0 && b < 0 && c < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            //check if first number contain 0
            else if(a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("0");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }

