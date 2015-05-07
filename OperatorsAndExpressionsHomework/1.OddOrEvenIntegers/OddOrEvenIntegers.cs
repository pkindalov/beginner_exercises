using System;


    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {

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
    

