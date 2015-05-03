using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            //Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

            Console.WriteLine("Write your birth year: ");
            int yourBirthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after how many years: ");
            int afterHowManyYears = int.Parse(Console.ReadLine());
      
            DateTime dateNow = new DateTime(2015, 5, 3);

            int yourAgeNow = dateNow.Year - yourBirthYear;
            Console.WriteLine("You are now at age " +yourAgeNow);
            Console.WriteLine("After " + afterHowManyYears + " years" + " you will be at " + (yourAgeNow + afterHowManyYears));
           
        }
    }

