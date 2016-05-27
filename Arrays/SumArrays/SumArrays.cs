using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bigger = Math.Max(arr1.Length, arr2.Length);

            int[] sumArray = new int[bigger];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
                
            }

            Console.WriteLine(string.Join(" ", sumArray));

        }
    }
}
