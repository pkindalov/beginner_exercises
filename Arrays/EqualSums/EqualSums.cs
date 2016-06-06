using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool found = false;

            for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
            {
                int rightIndexSum = 0;
                int leftIndexSum = 0;
                

                for (int left = 0; left < currentIndex; left++)
                {
                    leftIndexSum += numbers[left];
                }

                for (int right = currentIndex + 1; right < numbers.Length; right++)
                {
                    rightIndexSum += numbers[right];
                }

                if (leftIndexSum == rightIndexSum)
                {
                    Console.WriteLine(currentIndex);
                    found = true;
                    break;
                }


            }

            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
