using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {

        static private  SortedDictionary<double, int> fillTheCounters(List<double> numbers, SortedDictionary<double, int> counts)
        {
            foreach (var nums in numbers)
            {
                if (counts.ContainsKey(nums))
                {
                    counts[nums]++;
                }else
                {
                    counts[nums] = 1;
                }
               
            }

            return counts;

        }



        //private static double searchNums(SortedDictionary<double, int> filledCounts)
        //{
        //    foreach (var nums in filledCounts.Keys)
        //    {
        //        return nums, filledCounts[nums];
        //    }


        //}


        static void Main(string[] args)
        {
            //List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //var counts = new SortedDictionary<double, int>();

            //foreach (var nums in numbers)
            //{
            //    if (counts.ContainsKey(nums))
            //    {
            //        counts[nums]++;
            //    }
            //    else
            //    {
            //        counts[nums] = 1;
            //    }
            //}


            //foreach (var nums in counts.Keys)
            //{
            //    Console.WriteLine($"{nums} -> {counts[nums]} times");
            //}





            //second way
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();

            var filledCounts = fillTheCounters(numbers, counts);

            foreach (var nums in filledCounts.Keys)
            {
                Console.WriteLine("{0} -> {1}", nums, filledCounts[nums]);
            }


        }
    }
}
