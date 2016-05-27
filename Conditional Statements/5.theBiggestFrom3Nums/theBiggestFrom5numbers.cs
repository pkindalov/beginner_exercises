using System;
using System.Threading;
using System.Globalization;


    class theBiggestFrom5numbers
    {
        static void Main()
        {
            //Problem 6. The Biggest of Five Numbers

            //Write a program that finds the biggest of five numbers by using only five if statements.
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter a number one: ");
            double a = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter number two: ");
            double b = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter fourth number: ");
            double d = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter fifth number: ");
            double e = double.Parse(Console.ReadLine().Replace(',', '.'));


            if (a > b && a > c && a > d && a > e) Console.WriteLine("The biggest number is {0}", a);
            if (b > a && b > c && b > d && b > e) Console.WriteLine("The biggest number is {0}", b);
            if (c > a && c > b && c > d && c > e) Console.WriteLine("The biggest number is {0}", c);
            if (d > a && d > b && d > c && d > e) Console.WriteLine("The biggest number is {0}", d);
            if (e > a && e > b && e > c && e > d) Console.WriteLine("The biggest number is {0}", e);
        }
    }

