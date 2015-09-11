using System;
using System.Threading;
using System.Globalization;


    class exchangeIfGreater
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Problem 1. Exchange If Greater
            //Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
            //As a result print the values a and b, separated by a space.
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter a number 1: ");
            double num1 = double.Parse(Console.ReadLine().Replace(',', '.'));
            Console.Write("Enter a number 2: ");
            double num2 = double.Parse(Console.ReadLine().Replace(',', '.'));
            double neutralNum;

            if (num1 > num2)
            {
                neutralNum = num1;
                num1 = num2;
                num2 = neutralNum;
                Console.WriteLine("Result: {0} {1}", num1, neutralNum);
            }
            else
            {
                Console.WriteLine("Result: {0} {1}", num1, num2);
            }


        }
    }

