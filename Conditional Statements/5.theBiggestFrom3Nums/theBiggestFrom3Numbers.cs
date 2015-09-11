using System;
using System.Threading;
using System.Globalization;


    class theBiggestFrom3Numbers
    {
        static void Main()
        {
             Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Problem 5. The Biggest of 3 Numbers

            //Write a program that finds the biggest of three numbers.
            



            Console.Write("Enter a number one: ");
            double a = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter number two: ");
            double b = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine().Replace(',', '.'));


            if (a > b && a > c)
            {
                Console.WriteLine("The big number is {0}", a);
            }

            else if (b > a && b > c)
            {
                Console.WriteLine("The big number is {0}", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("The big number is {0}", c);
            }


        }
    }

