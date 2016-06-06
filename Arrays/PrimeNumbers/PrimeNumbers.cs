using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] numbers = new bool[n + 1];
            numbers[0] = false;
            numbers[1] = false;

            for (int i = 2; i <= n; i++)
            {
                numbers[i] = true;
            }


            for (int num = 2; num <= n; num++)
            {
                if (numbers[num])
                {
                    Console.WriteLine(num);
                    var step = 2 * num;

                    while (step <= n)
                    {
                        numbers[step] = false;
                        step += num;
                    }



                }


            }
        }
    }
}
