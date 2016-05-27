using System;


    class beerTime
    {
        static void Main()
        {
            Console.Write("Enter a time: ");
            DateTime yourSuggest = DateTime.Parse(Console.ReadLine());

            DateTime beerTimeGO = DateTime.Parse("1:00 PM");
            DateTime beerTimeEnd = DateTime.Parse("3:00 AM");

            if(yourSuggest >= beerTimeGO || yourSuggest <= beerTimeEnd)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes ! It is a beer time :) Cheers !");
                Console.ForegroundColor = ConsoleColor.Gray;
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry :( It is no beer time :( ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }
    }

