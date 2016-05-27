using System;
using System.Threading;
using System.Globalization;


    class NumberComparer
    {
        static void Main()
        {
            //Write a program that gets two numbers from the console and prints the greater of them.
            //Try to implement this without if statements.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter a number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Greater number is: {0}", n1 > n2 ? n1 : n2);



        }
    }

