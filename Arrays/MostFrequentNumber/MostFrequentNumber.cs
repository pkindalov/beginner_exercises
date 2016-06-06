using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {

            //works
            //char[] separators = new char[] { ' ', ';' };
            //string[] sentence = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //var query = (from i in sentence
            //             group i by i into g
            //             orderby g.Count() descending
            //             select new { Key = g.Key, Count = g.Count() }).FirstOrDefault();

            //if (query == null)
            //{
            //    Console.WriteLine("query = NULL");
            //}
            //else
            //{
            //    Console.WriteLine("{0}", query.Key);
            //}

            //else Console.WriteLine("The number '{0}' occurs {1} times.", query.Key, query.Count);


            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            ////Array.Sort(numbers);

            //int repeatedNum = 0;
            //int currentNumRepeat = 0;
            //int num = 0;

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        currentNumRepeat++;

            //        if (currentNumRepeat > repeatedNum)
            //        {
            //            repeatedNum = currentNumRepeat;
            //            num = numbers[i];
            //        }
            //    }
            //    else
            //    {
            //        currentNumRepeat = 0;
            //    }
            //}


            //Console.WriteLine(num);

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");
            //}


            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numCounts = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numCounts[i]++;
                    }
                }
               
            }


            //foreach (var item in numCounts)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            int max = 0;
            int number = 0;
            bool found = false;
            //int currentMax = 0;

            for (int i = 0; i < numCounts.Length; i++)
            {
                if (numCounts[i] > max)
                {
                    max = numCounts[i];
                }
            }


            
            //Console.WriteLine(numbers[max]);

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numCounts.Length; j++)
                {
                    if (numCounts[j] == max)
                    {
                        number = numbers[i];
                        found = true;
                    }
                }

                if (found)
                {
                    break;
                }
            }


            Console.WriteLine(number);
            Console.WriteLine(max);
            //Array.Sort(numbers);

            //int repeatedNum = 0;
            //int currentNumRepeat = 0;
            //int num = 0;

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        currentNumRepeat++;

            //        if (currentNumRepeat > repeatedNum)
            //        {
            //            repeatedNum = currentNumRepeat;
            //            num = numbers[i];
            //        }
            //    }
            //    else
            //    {
            //        currentNumRepeat = 0;
            //    }
            //}


            //Console.WriteLine(num);












        }
    }
}
