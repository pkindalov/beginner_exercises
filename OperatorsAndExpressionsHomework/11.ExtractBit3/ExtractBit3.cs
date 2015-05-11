using System;



    class ExtractBit3
    {
        static void Main()
        {
            //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
            //The bits are counted from right to left, starting from bit #0.
            //The result of the expression should be either 1 or 0.


            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position of bit to see it: ");
            int userPosition = int.Parse(Console.ReadLine());

            int mask = 1 << userPosition;
            int userNumberAndMask = userNumber & mask;
            int result = userNumberAndMask >> userPosition;

            Console.WriteLine("Number before operation: \n");
            Console.WriteLine(Convert.ToString(userNumber, 2).PadLeft(32, '0') + "\n");
            Console.WriteLine("With mask: ");
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
            Console.WriteLine("Number after intervence: \n");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0') + "\n");
            Console.WriteLine(result + "\n");

        }
    }

