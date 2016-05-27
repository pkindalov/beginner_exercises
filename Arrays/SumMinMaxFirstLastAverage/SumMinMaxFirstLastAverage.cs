using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxFirstLastAverage
{
    class SumMinMaxFirstLastAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());

            }

            //Console.WriteLine("Sum = " + nums.Sum());
            //Console.WriteLine("Min = " + nums.Min());
            //Console.WriteLine("Max = " + nums.Max());
            //Console.WriteLine("First = " + nums.First());
            //Console.WriteLine("Last = " + nums.Last());
            //Console.WriteLine("Average = " + nums.Average());


            //Старият начин

            //int sum = 0;
            //int minValue = int.MaxValue;
            //int maxValue = int.MinValue;


            int sum = nums[0];
            int minValue = nums[0];
            int maxValue = nums[0];
            int first = nums[0];
            //int last = nums[n - 1]; или int last = nums[nums.length - 1]; Еднакви са

            int last = nums[nums.Length - 1];


            for (int i = 1; i < n; i++)
            {
                sum += nums[i];

                if(nums[i] > maxValue)
                {
                    maxValue = nums[i];
                }

                if (nums[i] < minValue)
                {
                    minValue = nums[i];
                }


            }


            double average = (double)sum / n;

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {minValue}");
            Console.WriteLine($"Max = {maxValue}");
            Console.WriteLine($"First = {first}");
            Console.WriteLine($"Last = {last}");
            Console.WriteLine($"Average = {average}");


        }
    }
}
