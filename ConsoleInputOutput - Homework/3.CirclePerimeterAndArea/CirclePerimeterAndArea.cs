using System;
using System.Threading;
using System.Globalization;



    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Enter a perimeter: ");
            double perimeter = double.Parse(Console.ReadLine());

            double area = (r * perimeter) / 2;

            Console.Write("Perimeter: {0:F2}, \n Area: {1:F2}\n", perimeter, area);
        }
    }

