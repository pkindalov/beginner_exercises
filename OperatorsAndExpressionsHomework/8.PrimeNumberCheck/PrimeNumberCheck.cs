using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            //Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
            //Note: You should check if the number is positive

            Console.WriteLine("Enter an integer number bigger than 0 ");
            int yourNumber = int.Parse(Console.ReadLine());

            bool isPrime = true;
            if(yourNumber<=1)
            {
                isPrime = false;
                Console.WriteLine("Invalid number. Please write number bigger than 1");
            }

            for(int i = 2; i <= Math.Sqrt(yourNumber); i++)
            {

                if((i%2) == 0)
                {
                    isPrime = false;
                }

            }

            Console.WriteLine(isPrime);

        }
    }

