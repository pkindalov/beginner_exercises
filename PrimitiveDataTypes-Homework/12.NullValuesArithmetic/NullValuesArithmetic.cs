using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            //Create a program that assigns null values to an integer and to a double variable.
            //Try to print these variables at the console.
            //Try to add some number or the null literal to these variables and print the result.


            int? number1 = null;
            double? number2 = null;

            Console.WriteLine("!{0}! , !{1}!", number1, number2);

            number1 = 5;
            number2 = 3.5;

            Console.WriteLine("{0} , {1}", number1, number2);

            number1 = number1 + 23;
            number2 = number2 + 2.5;

            Console.WriteLine("{0} , {1}", number1, number2);

            number1 = 2 + null;
            number2 = 4.6 + null;

            Console.WriteLine("{0} , {1}", number1, number2);

        }
    }

