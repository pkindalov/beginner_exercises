using System;


    class ThirdDigitIs7
    {
        static void Main()
        {
            //Write an expression that checks for given integer if its third digit from right-to-left is 7

            Console.WriteLine("Enter a number: ");
            int yourNumber = int.Parse(Console.ReadLine());

            bool checkFor7 = ((yourNumber / 100) % 10 == 7);
            Console.WriteLine(checkFor7);

        }
    }

