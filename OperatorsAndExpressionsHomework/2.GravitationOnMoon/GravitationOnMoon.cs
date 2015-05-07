using System;


    class GravitationOnMoon
    {
        static void Main()
        {
            //The gravitational field of the Moon is approximately 17% of that on the Earth.
            //Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

            Console.WriteLine("Enter your Earth weight: ");
            double yourEarthWeight = double.Parse(Console.ReadLine());

            yourEarthWeight *= 0.17;
            Console.WriteLine("Your weight on Moon will be {0}", yourEarthWeight);
        }
    }

