using System;
using System.Threading;
using System.Globalization;

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number: ");
            double number = double.Parse(Console.ReadLine());
            double sum = 0;

            for (double i = 1; i <= number; i++)
            {

                Console.Write("Enter number {0}: ", i);
                double n = double.Parse(Console.ReadLine());
                sum += n;


            }

            Console.WriteLine(sum);


        }
    }

