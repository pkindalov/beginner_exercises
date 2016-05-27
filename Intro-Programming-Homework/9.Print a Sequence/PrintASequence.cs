using System;


    class PrintASequence
    {
        static void Main()
        {
            //Problem 8. Square Root

            //Create a console application that calculates and prints the square root of the number 12345.
            //Find in Internet “how to calculate square root in C#”.


            //first variant - easiest
            Console.WriteLine("2, -3, 4, -5, 6, -7, 8, -9, 10");


            //Second version - more complicated
            int numbers;
            for (int check = 2; check <= 11; check++)
            {
                if (check % 2 == 0)
                {
                    numbers = check;
                }
                else
                {
                    numbers = check * (-1);
                }

                Console.WriteLine(numbers);
            }
        }
    }

