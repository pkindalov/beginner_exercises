using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfKNumbers
{
    class SequenceOfKNumbers
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            int k = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();
            int series = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int current = i + 1;
                //Console.WriteLine(numbers[current]);


                if (i == current)
                {
                    series++;
                    if (series == k)
                    {
                        //result.Add(numbers[current]);
                        numbers.Remove(numbers[i]);
                    }

                }
                else
                {
                    //result.Add(numbers[current]);
                }
                

            }

            Console.WriteLine(string.Join(", ", numbers));
            
        }
    }
}
