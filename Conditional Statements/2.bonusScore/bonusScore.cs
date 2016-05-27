using System;


    class bonusScore
    {
        static void Main()
        {
            //    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
            //    If the score is between 1 and 3, the program multiplies it by 10.
            //    If the score is between 4 and 6, the program multiplies it by 100.
            //    If the score is between 7 and 9, the program multiplies it by 1000.
            //    If the score is 0 or more than 9, the program prints “invalid score”.


            Console.Write("Enter a number between 0 and 9: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 3)
            {
                int result = (userNumber * 10);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0}", result);
            }

            if (userNumber >= 4 && userNumber <= 6)
            {
                int result = (userNumber * 100);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0}", result);
            }

            if (userNumber >= 7 && userNumber <= 9)
            {
                int result = (userNumber * 1000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0}", result);
            }

            if (userNumber <= 0 || userNumber > 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid score");
            }


        }
    }

