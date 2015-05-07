using System;


    class OddOrEvenIntegers
    {
        static void Main()
        {

            //Write an expression that checks if given integer is odd or even.

             bool isOdd = false;
            Console.WriteLine("Enter some number: ");
            int someNumber = int.Parse(Console.ReadLine());

            if ((someNumber % 2) == 0)
            {
                isOdd = false;
            }
            else
            {
                isOdd = true;
            }

            Console.WriteLine(isOdd);

        }

        }
    

