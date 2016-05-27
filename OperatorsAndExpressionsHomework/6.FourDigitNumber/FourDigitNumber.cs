using System;



    class FourDigitNumber
    {
        static void Main()
        {

            //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
            //Prints on the console the number in reversed order: dcba (in our example 1102).
            //Puts the last digit in the first position: dabc (in our example 1201).
            //Exchanges the second and the third digits: acbd (in our example 2101).
            //The number has always exactly 4 digits and cannot start with 0.

            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());


            if ((userNumber % 10 == 0) && (userNumber < 4))
            {
                Console.WriteLine("Your number cannot begin with 0 or to contain little than 4 digits.");
            }


            int a = ((userNumber / 1000) % 10);
            int b = ((userNumber / 100) % 10);
            int c = ((userNumber / 10) % 10);
            int d = userNumber % 10;

            //reverse mode for second way. More complicated
            string a1 = Convert.ToString(a);
            string b1 = Convert.ToString(b);
            string c1 = Convert.ToString(c);
            string d1 = Convert.ToString(d);
            string reverse = d1 + c1 + b1 + a1;
            string lastDigitFirstPosition = d1 + a1 + b1 + c1;
            string exchangeSecAndThirdDigits = a1 + c1 + b1 + d1;

            int sumOfDigits = a + b + c + d;

            Console.WriteLine("Sum of digits {0}", sumOfDigits);
            Console.WriteLine("In reverse mode - first way {0}{1}{2}{3}", d, c, b, a); //reverse mode.. simple way
            Console.WriteLine("Reverse in second way {0}", reverse);
            Console.WriteLine("Last digit in the first position first way {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Last digit first position second way {0}", lastDigitFirstPosition);
            Console.WriteLine("Exchanges the second and the third digits 1st way {0}{1}{2}{3}", a, c, b, d);
            Console.WriteLine("Exchanges the second and the third digits 2nd way {0}", exchangeSecAndThirdDigits);

        }
    }

