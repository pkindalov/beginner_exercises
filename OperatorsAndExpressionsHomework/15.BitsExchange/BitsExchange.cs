using System;

    class BitsExchange
    {
        static void Main()
        {

            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            Console.WriteLine("Enter a number: ");
            uint yourNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(yourNumber, 2).PadLeft(32, '0'));


            for (int bits = 3; bits < 6; bits++)
            {
                if ((yourNumber >> bits & 1U) == (yourNumber >> (bits + 21) & 1))
                {
                    Console.WriteLine("Bits {0} and {1} are equal. No exchange.", bits, (bits + 21));
                }

                if ((yourNumber >> bits & 1U) == 1)
                {
                    yourNumber = ~(1U << bits) & yourNumber;
                    yourNumber = (1U << (bits + 21)) | yourNumber;
                }
                else
                {
                    yourNumber = (1U << bits) | yourNumber;
                    yourNumber = ~(1U << (bits + 21)) & yourNumber;
                }

            }


            Console.WriteLine(Convert.ToString(yourNumber, 2).PadLeft(32, '0'));
            Console.WriteLine(yourNumber);
            




        }
    }

