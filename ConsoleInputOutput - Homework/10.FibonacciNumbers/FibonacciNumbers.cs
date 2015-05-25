using System;
using System.Numerics;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            BigInteger f0 = 0;
            BigInteger f1 = 1;
            BigInteger sum;

            Console.WriteLine(f1);

            for(int i = 0; i <= number; i++)
            {
                sum = f0 + f1;
                f0 = f1;
                f1 = sum;

                Console.WriteLine(sum);
            }





        }
    }

