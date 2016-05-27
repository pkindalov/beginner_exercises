using System;

    class QuotesInStrings
    {
        static void Main()
        {
           // Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
           //Do the above in two different ways - with and without using quoted strings.
           //Print the variables to ensure that their value was correctly defined.

            string way1 = "The \"use\" of quotations causes difficulties";
            string way2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(way1);
            Console.WriteLine(way2);
        }
    }

