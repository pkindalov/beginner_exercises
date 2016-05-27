using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {

        private static bool IsPrime(long number)
        {
            bool isPrime = true;

            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }





        static List<long> FindPrimesInRange(int min, int max)
        {
            List<long> primes = new List<long>();

            bool isPrime = false;


            for (int i = min; i <= max; i++)
            {

                if (isPrime = IsPrime(i))
                {
                    primes.Add(i);
                }

            }



            return primes;
        }











        static void Main(string[] args)
        {

            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            List<long> PrimesInRange = new List<long>();


            PrimesInRange = FindPrimesInRange(min, max);


            Console.WriteLine(string.Join(", ", PrimesInRange));



        }
    }
}
