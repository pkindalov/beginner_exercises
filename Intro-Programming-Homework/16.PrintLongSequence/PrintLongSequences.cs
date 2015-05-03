using System;


    class PrintLongSequences
    {
        static void Main()
        {
            //Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

            int number;

            for (int sequences = 2; sequences <= 1001; sequences++)
            {
                if (sequences % 2 == 0)
                {
                    number = sequences;
                }
                else
                {
                    number = sequences * (-1);
                }
                Console.WriteLine(number);
            }
        }
    }

