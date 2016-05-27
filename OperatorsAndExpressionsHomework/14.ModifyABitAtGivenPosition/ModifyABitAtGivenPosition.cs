using System;

    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            //We are given an integer number n, a bit value v (v=0 or 1) and a position p.
            //Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.


            Console.WriteLine("Enter a number: ");
            int userEnteredNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit position: ");
            int userEnterdBitPos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value(0-1): ");
            int userEnteredValue = int.Parse(Console.ReadLine());

            if (userEnteredValue == 1)
            {
                int mask = 1 << userEnterdBitPos;
                int newNumber = userEnteredNumber | mask;
                Console.WriteLine("New number is {0} \n", newNumber);
                Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(16, '0'));
            }
            else
            {
                int mask = ~(1 << userEnterdBitPos);
                int newNumber = userEnteredNumber & mask;
                Console.WriteLine("New number is {0} \n", newNumber);
                Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(16, '0'));
            }



        }
    }

