using System;



    class PrintTheASCIITable
    {
        static void Main()
        {

            for (int c = 0; c <= 128; c++)
            {
                Console.Write("{0}", (char)c);
            }

        }
    }

