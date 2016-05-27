using System;
using System.Threading;
using System.Globalization;


    class sort3NumbersWithNestedIFS
    {
        static void Main()
        {
            //Problem 7. Sort 3 Numbers with Nested Ifs

            //Write a program that enters 3 real numbers and prints them sorted in descending order.
            //Use nested if statements.
            //Note: Don’t use arrays and the built-in sorting functionality.
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            Console.Write("Enter a number one: ");
            double a = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter number two: ");
            double b = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter third number: ");
            double c = double.Parse(Console.ReadLine().Replace(',', '.'));


            if (a >= b && a >= c)
            {
                if (b >= c) Console.WriteLine("{0} {1} {2}", a, b, c);
                if (b <= c) Console.WriteLine("{0} {1} {2}", a, c, b);
            }else if (b >= a && b >= c)
            {
                if (a >= c) Console.WriteLine("{0} {1} {2}", b, a, c);
                if (a <= c) Console.WriteLine("{0} {1} {2}", b, c, a);
            }else if (c >= a && c >= b)
            {
                if (a >= b) Console.WriteLine("{0} {1} {2}", c, a, b);
                if (a <= b) Console.WriteLine("{0} {1} {2}", c, b, a);
            }




        }
    }

