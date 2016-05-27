using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {

            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).Where(e => e => 0).Reverse());

            //Console.WriteLine(string.Join(" " , nums));

            //var positives = new List<int>();

            //foreach (var num in nums)
            //{
            //    if (num >= 0)
            //    {
            //        positives.Add(num);
            //    }

            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if (nums[i] < 0)
            //    {
            //        nums.RemoveAt(i);
            //        i--;
            //    }
            //}

            //nums.Reverse();
            //Console.WriteLine(string.Join(" ", nums));

            //if(nums.Count == 0)
            //{
            //    Console.WriteLine("Empty");
            //}

        }
    }
}
