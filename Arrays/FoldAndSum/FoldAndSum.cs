using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] arrMiddle = new int[2 * k];
            int[] arrNew = new int[2 * k];
            int[] arrSum = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                arrMiddle[i] = arr[k + i];
            }

            for (int i = 0; i < k; i++)
            {
                arrNew[i] = arr[k - 1 - i];
            }

            for (int i = 0; i < k; i++)
            {
                arrNew[k + i] = arr[4 * k - 1 - i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                arrSum[i] = arrMiddle[i] + arrNew[i];
            }
            Console.WriteLine(string.Join(" ", arrSum));
        }
    }
}
