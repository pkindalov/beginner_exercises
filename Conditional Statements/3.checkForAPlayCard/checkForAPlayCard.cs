using System;


class checkForAPlayCard
{
    static void Main()
    {

        //Problem 3. Check for a Play Card

        //Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:


        Console.Write("Enter something: ");
        string userText = Console.ReadLine();

        //first way - with ifs
        //if (userText == "2")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "3")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "4")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "5")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "6")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "7")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "8")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "9")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "10")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "J")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "Q")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "K")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}

        //else if (userText == "A")
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("No");
        //}




        //Second way with switch
        switch (userText)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No");
                Console.ForegroundColor = ConsoleColor.Gray;
                break;


        }
    }
}
