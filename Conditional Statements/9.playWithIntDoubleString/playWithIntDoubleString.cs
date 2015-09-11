using System;
using System.Threading;
using System.Globalization;


    class playWithIntDoubleString
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Problem 9. Play with Int, Double and String
            //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            //If the variable is int or double, the program increases it by one.
            //If the variable is a string, the program appends * at the end.
            //Print the result at the console. Use switch statement.



            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> INT");
            Console.WriteLine("2 --> DOUBLE");
            Console.WriteLine("3 --> STRING");
            int userAnswer = int.Parse(Console.ReadLine());

            switch (userAnswer)
            {
                case 1:
                    Console.WriteLine("Please enter an integer number: ");
                    int num = int.Parse(Console.ReadLine());
                    num += 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The result number is: {0}", num);
                    break;
                case 2:
                    Console.WriteLine("Enter a double number: ");
                    double numDouble = double.Parse(Console.ReadLine().Replace(',', '.'));
                    numDouble += 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The result number is: {0}", numDouble);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string: ");
                    string userSomeText = Console.ReadLine();
                    string star = "*";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(userSomeText + star);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Try again");
                    break;
            }
        }
    }

