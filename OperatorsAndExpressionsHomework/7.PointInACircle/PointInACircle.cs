﻿using System;

    class PointInACircle
    {
        static void Main()
        {
            //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

            Console.WriteLine("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = (x * x) + (y * y) <= 2 * 2;
            Console.WriteLine("Are coordinates in circle: {0}", result);
        }
    }
