using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            for (int left = 0; left < numbers.Length; left++)
            {
                for (int right = left + 1; right < numbers.Length; right++)
                {
                    int sum = numbers[left] + numbers[right];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", numbers[left], numbers[right], sum);
                        count++;
                    }


                    



                    
                }


            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }


        }
    }
}
