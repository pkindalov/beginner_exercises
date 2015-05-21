using System;
using System.Threading;
using System.Globalization;

    class QuadraticEquation
    {
        static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A must be greater than 0");
                return;
            }

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

         
            double D = (b * b) - 4 * (a * c);
            Console.WriteLine("D is {0}", D);

            if(D < 0)
            {
                Console.WriteLine("Quadratic equation has no real roots");
            }else if(D == 0)
            {
                Console.WriteLine("Quadratic equation has one root");
                double x = -(b / 2 * a);
                Console.WriteLine("The root is {0}", x);

            }else if(D > 0)
            {
                Console.WriteLine("Quadratic equation has two roots");

                double x1 = -(b + (Math.Sqrt(D))) / (2 * a);
                double x2 = -(b - (Math.Sqrt(D))) / (2 * a);
                Console.WriteLine("Roots are: x1 = {0}, x2 = {1}", x1, x2);
            }











        }
    }

