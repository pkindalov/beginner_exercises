using System;


    class ExchangeVariableValues
    {
        static void Main()
        {
            //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
            //Print the variable values before and after the exchange.

            int a = 5;
            int b = 10;
            int temporary;

            Console.WriteLine("Before exchange values are: a = {0} , b = {1}", a, b);

            temporary = a;
            a = b;
            b = temporary;

            Console.WriteLine("After echange values are: a = {0}, b = {1}", a, b);

        }
    }

