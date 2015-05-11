using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.

            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What position of bit: ");
            int bitPosition = int.Parse(Console.ReadLine());


            int mask = 1 << bitPosition;
            int numberAndMask = userNumber & mask;
            int result = numberAndMask >> bitPosition;

            Console.WriteLine("Your number before intervence: {0}\n", userNumber);
            Console.WriteLine(Convert.ToString(userNumber, 2).PadLeft(32, '0'));
            Console.WriteLine("With mask: \n");
            Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));
            Console.WriteLine("The number after intervence is \n");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("The value of bit in position {0} is {1}", bitPosition, result);


        }
    }

