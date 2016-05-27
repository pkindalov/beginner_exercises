using System;


    class NumInIntDivByGivenNumbert
    {
        static void Main(string[] args)
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

            Console.Write("Enter number one: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number two: ");
            int n2 = int.Parse(Console.ReadLine());
            int p = 0;
            int count = 0;

            for (int i = n1; i <= n2; i++)
            {
                if ((i % 5) == 0)
                {
                    p = i;
                    Console.WriteLine(p);
                    count++;
                }
            }
            Console.WriteLine("p = {0}", count);
        }
    }

