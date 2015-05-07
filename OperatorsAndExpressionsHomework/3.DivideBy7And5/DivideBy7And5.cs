using System;

    class DivideBy7And5
    {
        static void Main()
        {
            //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.


            bool result = false;
            Console.WriteLine("Enter a number: ");
            int yourNumber = int.Parse(Console.ReadLine());

            result = (yourNumber % 5 == 0) & (yourNumber % 7 == 0);
            Console.WriteLine(result);
        }
    }

