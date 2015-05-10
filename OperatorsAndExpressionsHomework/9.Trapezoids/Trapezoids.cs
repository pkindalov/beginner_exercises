using System;

    class Trapezoids
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.

            Console.WriteLine("Enter side A of trapezoid: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of trapezoid: ");
            double heightTrapezoid = double.Parse(Console.ReadLine());

            double area = ((sideA + sideB) / 2) * heightTrapezoid;

            Console.WriteLine("Area of trapezoid is {0}", area);
        }
    }

