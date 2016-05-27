using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {

            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var count = new int[nums.Max() + 1];

            //foreach (var num in nums)
            //{
            //    count[num]++;
            //}


            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] != 0)
            //    {
            //        Console.WriteLine("{0} -> {1}", i, count[i]);
            //    }

            //}

            //////////////////////////////////////////////////////////////////////////////////////


            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            nums.Sort();

            for (int start = 0; start < nums.Count; start++)
            {
                int count = 1;

                while(start + count < nums.Count && nums[start] == nums[start+count])
                {
                    
                    count++;
                   
                }

                Console.WriteLine($"{nums[start]} -> {count}");
            }


        }
    }
}
