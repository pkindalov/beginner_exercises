using System;
using System.Threading;
using System.Globalization;


    class SumOf3Numbers
    {
        static void Main()
        {
            //Write a program that reads 3 real numbers from the console and prints their sum.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;  //set regional settings to universal with purpose console to not
                                                                                //broke down when we entered symbols - ',' or '.' depends of environment
                                                                                 
            Console.WriteLine("Enter first number: ");
            double userNumber1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double userNumber2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third number: ");
            double userNumber3 = double.Parse(Console.ReadLine());

            double sum = (double)(userNumber1 + userNumber2 + userNumber3);

            Console.WriteLine("The sum of numbers is: {0}", sum);

        }
    }

