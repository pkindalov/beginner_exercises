using System;

    class ComparingFloats
    {
        static void Main()
        {
            //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
            //Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
            //Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.



            bool isEqual = false;
            double number1, number2;
            double eps = 0.000001;
            double difference;
            double absoluteValue;

            Console.WriteLine("Enter number 1: ");
            number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            number2 = double.Parse(Console.ReadLine());

            difference = number1 - number2;
            absoluteValue = Math.Abs(difference);

            if (absoluteValue < eps)
            {
                isEqual = true;
            }
            Console.WriteLine("Number 1 -> {0}, number 2  -> {1}, \n difference between two numbers {2}, \n absolut value {3} , \n are they equal {4}", number1, number2, difference, absoluteValue, isEqual);
            Console.WriteLine(isEqual);




        }
    }

