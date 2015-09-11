using System;
using System.Threading;
using System.Globalization;



    class digitAsWord
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Problem 8. Digit as Word

            //Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
            //Print “not a digit” in case of invalid input.
            //Use a switch statement.


            Console.Write("Enter some number from 0 to 9: ");
            string number = Console.ReadLine();

            switch(number)
            {
                case "0":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Zero");
                    break;
                case "1":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("One");
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Two");
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Three");
                    break;
                case "4":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Four");
                    break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Five");
                    break;
                case "6":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Six");
                    break;
                case "7":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Seven");
                    break;
                case "8":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Eight");
                    break;
                case "9":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a digit");
                    break;

            }



          

        }
    }

