using System;
using System.Threading;
using System.Globalization;



    class CirclePerimeterAndArea
    {
        static void Main()
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter a perimeter: ");
            double perimeter = double.Parse(Console.ReadLine().Replace(',', '.'));

            double area = (r * perimeter) / 2;

            Console.Write("Perimeter: {0:F2}, \n Area: {1:F2}\n", perimeter, area);
        }
    }

