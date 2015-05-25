using System;
using System.Threading;
using System.Globalization;


    class SumOf5Numbers
    {
        static void Main()
        {

            //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number 1: ");
            double n1 = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter number 2: ");
            double n2 = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter number 3: ");
            double n3 = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter number 4: ");
            double n4 = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter number 5: ");
            double n5 = double.Parse(Console.ReadLine().Replace(',', '.'));

            double sum = n1 + n2 + n3 + n4 + n5;
            Console.WriteLine("{0} {1} {2} {3} {4}     {5} ", n1, n2, n3, n4, n5, sum);

        }
    }

