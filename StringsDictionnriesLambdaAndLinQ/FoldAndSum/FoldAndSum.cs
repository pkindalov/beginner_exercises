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
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;

            var rowLeft = numbers.Take(k).Reverse();
            var rowRight = numbers.Reverse().Take(k);

            int[] row1 = rowLeft.Concat(rowRight).ToArray();
            int[] row2 = numbers.Skip(k).Take(2 * k).ToArray();

            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sum));


            //Console.Write("/" + new string('-', 20) + "\\");
        }
    }
}
