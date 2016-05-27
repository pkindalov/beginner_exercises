using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = 2; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);

        }
    }
}
