using System;

    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Position of bit who want to check: ");
            int positionBit = int.Parse(Console.ReadLine());

            bool isOne = false;
            Console.WriteLine("Your number is {0}\n", userNumber);
            Console.WriteLine(Convert.ToString(userNumber, 2).PadLeft(32, '0') + "\n");
            int searchForBit = userNumber >> positionBit;
            Console.WriteLine("Searching for bit: \n");
            Console.WriteLine(Convert.ToString(searchForBit, 2).PadLeft(32, '0') + "\n");
            int mask = searchForBit & 1;
            Console.WriteLine("Mask:\n");
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0') + "\n");

            if(mask == 1)
            {
                isOne = true;
            }

            Console.WriteLine(isOne);





        }
    }

