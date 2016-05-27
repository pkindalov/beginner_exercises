using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int
                .Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < k; i++)
            {
                //rotate array
                int lastElement = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = lastElement;
                //Console.Write(string.Join(" ", numbers));
                //sum

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] = sum[j] + numbers[j];
                }
                

            }

            Console.Write(string.Join(" ", sum));

            //for (int i = 0; i < k; i++)
            //{
            //    int firstElement = numbers[0];
            //    numbers[0] = numbers[numbers.Length - 1];
            //    numbers[numbers.Length - 1] = firstElement;
            //}

            //Console.Write(string.Join(" ", numbers));

        }
    }
}
